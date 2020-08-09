using NLog.LayoutRenderers;
using RTCV.CorruptCore;
using RTCV.NetCore;
using RTCV.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vanguard;

namespace FileStub
{
    public partial class StubForm : Form
    {

        public StubForm()
        {
            InitializeComponent();

            SyncObjectSingleton.SyncObject = this;


        Text += FileWatch.FileStubVersion;

            this.cbSelectedExecution.Items.AddRange(new object[] {
                //ExecutionType.NO_EXECUTION,
                //ExecutionType.EXECUTE_CORRUPTED_FILE,
                //ExecutionType.EXECUTE_WITH,
                ExecutionType.EXECUTE_OTHER_PROGRAM,
                //ExecutionType.SCRIPT,
            });

            this.cbTargetType.Items.AddRange(new object[] {
                TargetType.SINGLE_FILE,
                //TargetType.MULTIPLE_FILE_SINGLEDOMAIN,
                //TargetType.MULTIPLE_FILE_MULTIDOMAIN,
                //TargetType.MULTIPLE_FILE_MULTIDOMAIN_FULLPATH,
            });

        }

        private void StubForm_Load(object sender, EventArgs e)
        {
            cbSelectedExecution.SelectedIndex = 0;
            cbTargetType.SelectedIndex = 0;

            UICore.SetRTCColor(Color.LightCoral, this);

            FileWatch.Start();
        }

        public void RunProgressBar(string progressLabel, int maxProgress, Action<object, EventArgs> action, Action<object, EventArgs> postAction = null)
        {

            if (FileWatch.progressForm != null)
            {
                FileWatch.progressForm.Close();
                this.Controls.Remove(FileWatch.progressForm);
                FileWatch.progressForm = null;
            }

            FileWatch.progressForm = new ProgressForm(progressLabel, maxProgress, action, postAction);
            FileWatch.progressForm.Run();

        }

        private void CbSelectedExecution_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cbSelectedExecution.SelectedItem.ToString();

            FileWatch.currentFileInfo.selectedExecution = selected;

            switch (selected)
            {
                case ExecutionType.EXECUTE_CORRUPTED_FILE:
                case ExecutionType.EXECUTE_WITH:
                case ExecutionType.EXECUTE_OTHER_PROGRAM:
                    lbArgs.Visible = true;
                    tbArgs.Visible = true;
                    btnKillProcess.Visible = true;
                    btnEditExec.Visible = true;
                    btnEditExec.Text = "Edit Exec";
                    break;

                    
                case ExecutionType.NO_EXECUTION:
                    lbArgs.Visible = false;
                    tbArgs.Visible = false;
                    btnKillProcess.Visible = false;
                    btnEditExec.Visible = false;
                    btnEditExec.Text = "Edit Exec";
                    break;

                case ExecutionType.SCRIPT:
                default:
                    lbArgs.Visible = false;
                    tbArgs.Visible = false;
                    btnKillProcess.Visible = true;
                    btnEditExec.Visible = true;
                    btnEditExec.Text = "Edit Script";
                    break;
            }

            Executor.RefreshLabel();

        }

        private void BtnEditExec_Click(object sender, EventArgs e)
        {
            Executor.EditExec();
        }


        Size originalLbTargetSize;
        Point originalLbTargetLocation;
        public void EnableTargetInterface()
        {
            var diff = lbTarget.Location.X - btnLoadTarget.Location.X;
            originalLbTargetLocation = lbTarget.Location;
            lbTarget.Location = btnLoadTarget.Location;
            lbTarget.Visible = true;

            btnTargetSettings.Visible = false;

            btnLoadTarget.Visible = false;
            originalLbTargetSize = lbTarget.Size;
            lbTarget.Size = new Size(lbTarget.Size.Width + diff, lbTarget.Size.Height);
            btnUnloadTarget.Visible = true;
            cbTargetType.Enabled = false;



            FileWatch.EnableInterface();

            lbExecution.Visible = true;
            cbSelectedExecution.Visible = true;

            lbTargetStatus.Text = FileWatch.currentFileInfo.selectedTargetType.ToString() + " target loaded";
        }

        public void DisableTargetInterface()
        {
            btnUnloadTarget.Visible = false;
            btnLoadTarget.Visible = true;
            lbTarget.Size = originalLbTargetSize;
            lbTarget.Location = originalLbTargetLocation;
            lbTarget.Visible = false;
            cbTargetType.Enabled = true;

            btnTargetSettings.Visible = true;

            cbSelectedExecution.SelectedIndex = 0;


            lbExecution.Visible = false;
            cbSelectedExecution.Visible = false;

            btnRestoreBackup.Enabled = false;
            btnResetBackup.Enabled = false;
            btnClearAllBackups.Enabled = false;
            lbTarget.Text = "No target selected";
            lbTargetStatus.Text = "No target selected";
        }

        private void BtnLoadTarget_Click(object sender, EventArgs e)
        {
            //only use backups for uncorrupt, reset on every reload
            foreach (string file in Directory.GetFiles(Path.Combine(FileWatch.currentDir, "FILEBACKUPS")))
            {
                try
                {
                    File.Delete(file);
                }
                catch
                {
                    MessageBox.Show($"Could not delete file {file}");
                }
            }



            if (!FileWatch.LoadTarget())
                return;

            if (!VanguardCore.vanguardConnected)
                VanguardCore.Start();

            EnableTargetInterface();

        }

        public void BtnUnloadTarget_Click(object sender, EventArgs e)
        {
            if (!FileWatch.CloseTarget())
                return;
            DisableTargetInterface();
        }

        private void CbTargetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cbSelectedExecution.SelectedItem.ToString())
            FileWatch.currentFileInfo.selectedTargetType = cbTargetType.SelectedItem.ToString();

        }

        private void BtnKillProcess_Click(object sender, EventArgs e)
        {
            FileWatch.KillProcess();
        }

        private void BtnRestoreBackup_Click(object sender, EventArgs e)
        {
            FileWatch.currentFileInfo.targetInterface?.CloseStream();
            FileWatch.currentFileInfo.targetInterface?.RestoreBackup();
        }

        private void BtnResetBackup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
@"This resets the backup of the current target by using the current data from it.
If you override a clean backup using a corrupted file,
you won't be able to restore the original file using it.

Are you sure you want to reset the current target's backup?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            FileWatch.currentFileInfo.targetInterface?.ResetBackup(true);

        }

        private void BtnClearAllBackups_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear ALL THE BACKUPS\n from FileStub's cache?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.No)
                return;


            FileWatch.currentFileInfo.targetInterface?.RestoreBackup();

            foreach (string file in Directory.GetFiles(Path.Combine(FileWatch.currentDir, "FILEBACKUPS")))
            {
                try
                {
                    File.Delete(file);
                }
                catch
                {
                    MessageBox.Show($"Could not delete file {file}");
                }
            }

            FileInterface.CompositeFilenameDico = new Dictionary<string, string>();
            FileWatch.currentFileInfo.targetInterface?.ResetBackup(false);
            FileInterface.SaveCompositeFilenameDico();
            MessageBox.Show("All the backups were cleared.");
        }

        private void BtnTargetSettings_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control c = (Control)sender;
                Point locate = new Point(c.Location.X + e.Location.X, ((Control)sender).Location.Y + e.Location.Y);

                ContextMenuStrip columnsMenu = new ContextMenuStrip();


                ((ToolStripMenuItem)columnsMenu.Items.Add("Big endian", null, new EventHandler((ob, ev) => {

                    FileWatch.currentFileInfo.bigEndian = !FileStub.FileWatch.currentFileInfo.bigEndian;

                    if (VanguardCore.vanguardConnected)
                        FileWatch.UpdateDomains();

                }))).Checked = FileWatch.currentFileInfo.bigEndian;

                ((ToolStripMenuItem)columnsMenu.Items.Add("Auto-Uncorrupt", null, new EventHandler((ob, ev) => {

                    FileWatch.currentFileInfo.autoUncorrupt = !FileWatch.currentFileInfo.autoUncorrupt;

                }))).Checked = FileWatch.currentFileInfo.autoUncorrupt;

                ((ToolStripMenuItem)columnsMenu.Items.Add("Use Caching + Multithreading", null, new EventHandler((ob, ev) => {

                    FileWatch.currentFileInfo.useCacheAndMultithread = !FileWatch.currentFileInfo.useCacheAndMultithread;

                }))).Checked = FileWatch.currentFileInfo.useCacheAndMultithread;

                columnsMenu.Show(this, locate);
            }
        }

        private void StubForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!FileWatch.CloseTarget(false))
                e.Cancel = true;
        }

        private void RunFile(string batchfile, bool waitForExit = false)
        {

            string fullPath = Path.Combine(FileWatch.currentDir, batchfile);

            if(!File.Exists(fullPath))
            {
                MessageBox.Show($"Could not find the file {fullPath}");
                return;
            }

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = Path.GetFileName(fullPath);
            psi.WorkingDirectory = Path.GetDirectoryName(fullPath);

            //if (!string.IsNullOrWhiteSpace(args))
            //    psi.Arguments = args;

            var p = Process.Start(psi);

            if (waitForExit)
                p.WaitForExit();
        }

        private void btnRestoreDriveBackup_Click(object sender, EventArgs e)
        {
            RunFile("DRIVE_BACKUP_RESTORE.bat");
        }
        public void MakeGuestOsConfig()
        {
            string guestosTemplateConfPath = Path.Combine(FileWatch.currentDir, "DOSBOX", "guestos_template.conf");
            string guestosConfPath = Path.Combine(FileWatch.currentDir, "DOSBOX", "guestos.conf");

            if (!File.Exists(guestosTemplateConfPath))
            {
                MessageBox.Show($"Could not find Guest OS config template {guestosTemplateConfPath}");
                return;
            }

            if (File.Exists(guestosConfPath))
                File.Delete(guestosConfPath);


            //string newConf = File.ReadAllText(guestosTemplateConfPath) + Environment.NewLine + tbAutoexec.Text;
            string newConf = File.ReadAllText(guestosTemplateConfPath);

            if(cbCopyDriveNextBoot.Checked)
            {
                string replaceText =
@"
MOUNT D DRIVE
C:
RD /s /q DRIVE 
mkdir DRIVE
D:
echo COPYING FILES TO VM 
echo THIS CAN TAKE A LONG TIME
echo IF THERE ARE BIG FILES TO TRANSFERT
copy *.* C:\DRIVE
";
                newConf = newConf.Replace("BOOT C:", replaceText + Environment.NewLine + "BOOT C:");

                cbCopyDriveNextBoot.Checked = false;
            }

            if (cbCustomAutoexec.Checked)
            {
                string replaceText = tbAutoexec.Text;
                newConf = newConf.Replace("BOOT C:", replaceText + Environment.NewLine + "BOOT C:");
            }

            File.WriteAllText(guestosConfPath, newConf);
        }

        public void MakeDosConfig()
        {
            string dosTemplateConfPath = Path.Combine(FileWatch.currentDir, "DOSBOX", "dos_template.conf");
            string dosConfPath = Path.Combine(FileWatch.currentDir, "DOSBOX", "dos.conf");

            if(!File.Exists(dosTemplateConfPath))
            {
                MessageBox.Show($"Could not find dos config template {dosTemplateConfPath}");
                return;
            }

            if (File.Exists(dosConfPath))
                File.Delete(dosConfPath);


            string newConf = File.ReadAllText(dosTemplateConfPath) + Environment.NewLine + tbAutoexec.Text;

            File.WriteAllText(dosConfPath, newConf);
        }

        private void btnStartDosbox_Click(object sender, EventArgs e)
        {
            RunFile("DOSBOX_KILL.bat", true);

            if (rbDOS.Checked)
            {
                MakeDosConfig();
                RunFile("DOSBOX_START_DOS.bat");
            }
            else
            {
                MakeGuestOsConfig();
                RunFile("DOSBOX_START_GUESTOS.bat");
            }
        }

        private void btnKillDosbox_Click(object sender, EventArgs e)
        {
            RunFile("DOSBOX_KILL.bat");
        }

        public void btnRamSaveState_Click(object sender, EventArgs e)
        {

            if (!btnLoadTarget.Visible)
                BtnUnloadTarget_Click(null, null);


            string savFilePath = Path.Combine(FileWatch.currentDir, "DOSBOX", "save", "1.sav");
            string memoryFilePath = Path.Combine(FileWatch.currentDir, "DOSBOX", "save", "Memory");


            //if (File.Exists(savFilePath))
            //    File.Delete(savFilePath);

            

            RunFile("DOSBOX\\SaveState.exe", true);

            //wait for memory file to exist
            while (true)
            {
                if (File.Exists(memoryFilePath))
                    break;

                Thread.Sleep(200); //retry in 200ms
            }

            //wait for memory file to disapear
            while (true)
            {
                if (!File.Exists(memoryFilePath))
                    break;

                Thread.Sleep(200); //retry in 200ms
            }

            //This detects that the savestate was written and finished writing
            while (true)
            {
                if(File.Exists(savFilePath))
                {

                    try {
                        var fs = File.OpenWrite(savFilePath);
                        Thread.Sleep(30);
                        fs.Close();
                        break;
                    }
                    catch {
                        new object();
                    } //if it falls in the catch, means it's still writing the savestate
                }

                Thread.Sleep(200); //retry in 200ms
            }


            RunFile("RAM_STATE_UNPACK.bat", true);


            if (btnLoadTarget.Visible)
                BtnLoadTarget_Click(null, null);

        }

        public void btnRamLoadState_Click(object sender, EventArgs e)
        {
            RepackState(true);

        }

        public void RepackState(bool LoadState)
        {
            RunFile("RAM_STATE_REPACK.bat", true);

            if(LoadState)
                RunFile("DOSBOX\\LoadState.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
@"The default Dos config will mount the DRIVE folder as C.
If you put a game in the DRIVE folder, add the call to starting the game
in the autoexec textbox.
"
                );
        }

        private void btnBrowseDriveFolder_Click(object sender, EventArgs e)
        {
            string driveFolder = Path.Combine(FileWatch.currentDir, "DOSBOX", "DRIVE");
            Process.Start(driveFolder);
        }

        private void btnLoadUncorrupted_Click(object sender, EventArgs e)
        {
            FileWatch.currentFileInfo.targetInterface?.CloseStream();
            FileWatch.currentFileInfo.targetInterface?.RestoreBackup(false);

            btnRamLoadState_Click(null, null);
        }

        private void btnShowAdvanced_Click(object sender, EventArgs e)
        {
            pnAdvancedDosbox.Location = pnBasicDosbox.Location;
            pnBasicDosbox.Visible = false;
        }

        private void btnDriveSaveState_Click(object sender, EventArgs e)
        {
            RunFile("DRIVE_STATE_SAVE.bat", true);
        }

        private void btnDriveLoadState_Click(object sender, EventArgs e)
        {
            RunFile("DRIVE_STATE_LOAD.bat", true);
        }
    }
}
