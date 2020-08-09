namespace FileStub
{
    partial class StubForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StubForm));
            this.label5 = new System.Windows.Forms.Label();
            this.pnTarget = new System.Windows.Forms.Panel();
            this.cbTargetType = new System.Windows.Forms.ComboBox();
            this.lbTarget = new System.Windows.Forms.Label();
            this.btnUnloadTarget = new System.Windows.Forms.Button();
            this.btnLoadTarget = new System.Windows.Forms.Button();
            this.btnTargetSettings = new System.Windows.Forms.Button();
            this.btnKillProcess = new System.Windows.Forms.Button();
            this.lbArgs = new System.Windows.Forms.Label();
            this.tbArgs = new System.Windows.Forms.TextBox();
            this.lbExecution = new System.Windows.Forms.Label();
            this.pnSideBar = new System.Windows.Forms.Panel();
            this.lbTargetStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearAllBackups = new System.Windows.Forms.Button();
            this.pnGlitchHarvesterOpen = new System.Windows.Forms.Panel();
            this.btnRestoreBackup = new System.Windows.Forms.Button();
            this.btnResetBackup = new System.Windows.Forms.Button();
            this.cbSelectedExecution = new System.Windows.Forms.ComboBox();
            this.pnTargetExecution = new System.Windows.Forms.Panel();
            this.btnEditExec = new System.Windows.Forms.Button();
            this.lbTargetExecution = new System.Windows.Forms.Label();
            this.pnDosbox = new System.Windows.Forms.Panel();
            this.cbCopyDriveNextBoot = new System.Windows.Forms.CheckBox();
            this.cbCustomAutoexec = new System.Windows.Forms.CheckBox();
            this.btnBrowseDriveFolder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAutoexec = new System.Windows.Forms.TextBox();
            this.rbGuestOS = new System.Windows.Forms.RadioButton();
            this.rbDOS = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestoreDriveBackup = new System.Windows.Forms.Button();
            this.btnLoadUncorrupted = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDriveLoadState = new System.Windows.Forms.Button();
            this.btnDriveSaveState = new System.Windows.Forms.Button();
            this.btnKillDosbox = new System.Windows.Forms.Button();
            this.btnRamLoadState = new System.Windows.Forms.Button();
            this.btnRamSaveState = new System.Windows.Forms.Button();
            this.btnStartDosbox = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnBasicDosbox = new System.Windows.Forms.Panel();
            this.btnShowAdvanced = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pnAdvancedDosbox = new System.Windows.Forms.Panel();
            this.pnTarget.SuspendLayout();
            this.pnSideBar.SuspendLayout();
            this.pnTargetExecution.SuspendLayout();
            this.pnDosbox.SuspendLayout();
            this.pnBasicDosbox.SuspendLayout();
            this.pnAdvancedDosbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(577, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Selected Target";
            this.label5.Visible = false;
            // 
            // pnTarget
            // 
            this.pnTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnTarget.Controls.Add(this.cbTargetType);
            this.pnTarget.Controls.Add(this.lbTarget);
            this.pnTarget.Location = new System.Drawing.Point(575, 170);
            this.pnTarget.Name = "pnTarget";
            this.pnTarget.Size = new System.Drawing.Size(395, 122);
            this.pnTarget.TabIndex = 13;
            this.pnTarget.Tag = "color:dark1";
            this.pnTarget.Visible = false;
            // 
            // cbTargetType
            // 
            this.cbTargetType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTargetType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cbTargetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTargetType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTargetType.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbTargetType.ForeColor = System.Drawing.Color.White;
            this.cbTargetType.FormattingEnabled = true;
            this.cbTargetType.Location = new System.Drawing.Point(12, 14);
            this.cbTargetType.Name = "cbTargetType";
            this.cbTargetType.Size = new System.Drawing.Size(284, 21);
            this.cbTargetType.TabIndex = 118;
            this.cbTargetType.TabStop = false;
            this.cbTargetType.Tag = "color:dark2";
            this.cbTargetType.SelectedIndexChanged += new System.EventHandler(this.CbTargetType_SelectedIndexChanged);
            // 
            // lbTarget
            // 
            this.lbTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.lbTarget.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbTarget.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lbTarget.Location = new System.Drawing.Point(87, 39);
            this.lbTarget.Name = "lbTarget";
            this.lbTarget.Padding = new System.Windows.Forms.Padding(3, 6, 1, 1);
            this.lbTarget.Size = new System.Drawing.Size(296, 72);
            this.lbTarget.TabIndex = 36;
            this.lbTarget.Tag = "color:dark2";
            this.lbTarget.Text = "No target selected";
            this.lbTarget.Visible = false;
            // 
            // btnUnloadTarget
            // 
            this.btnUnloadTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnloadTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnUnloadTarget.FlatAppearance.BorderSize = 0;
            this.btnUnloadTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnloadTarget.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnUnloadTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUnloadTarget.Location = new System.Drawing.Point(87, 117);
            this.btnUnloadTarget.Name = "btnUnloadTarget";
            this.btnUnloadTarget.Size = new System.Drawing.Size(82, 23);
            this.btnUnloadTarget.TabIndex = 42;
            this.btnUnloadTarget.TabStop = false;
            this.btnUnloadTarget.Tag = "color:dark2";
            this.btnUnloadTarget.Text = "Unload";
            this.btnUnloadTarget.UseVisualStyleBackColor = false;
            this.btnUnloadTarget.Visible = false;
            this.btnUnloadTarget.Click += new System.EventHandler(this.BtnUnloadTarget_Click);
            // 
            // btnLoadTarget
            // 
            this.btnLoadTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLoadTarget.FlatAppearance.BorderSize = 0;
            this.btnLoadTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTarget.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnLoadTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLoadTarget.Location = new System.Drawing.Point(11, 117);
            this.btnLoadTarget.Name = "btnLoadTarget";
            this.btnLoadTarget.Size = new System.Drawing.Size(72, 23);
            this.btnLoadTarget.TabIndex = 35;
            this.btnLoadTarget.TabStop = false;
            this.btnLoadTarget.Tag = "color:dark2";
            this.btnLoadTarget.Text = "Load";
            this.btnLoadTarget.UseVisualStyleBackColor = false;
            this.btnLoadTarget.Click += new System.EventHandler(this.BtnLoadTarget_Click);
            // 
            // btnTargetSettings
            // 
            this.btnTargetSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTargetSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTargetSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTargetSettings.FlatAppearance.BorderSize = 0;
            this.btnTargetSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTargetSettings.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnTargetSettings.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnTargetSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnTargetSettings.Image")));
            this.btnTargetSettings.Location = new System.Drawing.Point(506, 13);
            this.btnTargetSettings.Name = "btnTargetSettings";
            this.btnTargetSettings.Size = new System.Drawing.Size(32, 32);
            this.btnTargetSettings.TabIndex = 172;
            this.btnTargetSettings.TabStop = false;
            this.btnTargetSettings.Tag = "color:dark1";
            this.btnTargetSettings.UseVisualStyleBackColor = false;
            this.btnTargetSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnTargetSettings_MouseDown);
            // 
            // btnKillProcess
            // 
            this.btnKillProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKillProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnKillProcess.FlatAppearance.BorderSize = 0;
            this.btnKillProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKillProcess.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnKillProcess.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnKillProcess.Location = new System.Drawing.Point(299, 38);
            this.btnKillProcess.Name = "btnKillProcess";
            this.btnKillProcess.Size = new System.Drawing.Size(81, 21);
            this.btnKillProcess.TabIndex = 55;
            this.btnKillProcess.TabStop = false;
            this.btnKillProcess.Tag = "color:dark2";
            this.btnKillProcess.Text = "Kill Process";
            this.btnKillProcess.UseVisualStyleBackColor = false;
            this.btnKillProcess.Click += new System.EventHandler(this.BtnKillProcess_Click);
            // 
            // lbArgs
            // 
            this.lbArgs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbArgs.AutoSize = true;
            this.lbArgs.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbArgs.ForeColor = System.Drawing.Color.White;
            this.lbArgs.Location = new System.Drawing.Point(12, 61);
            this.lbArgs.Name = "lbArgs";
            this.lbArgs.Size = new System.Drawing.Size(29, 13);
            this.lbArgs.TabIndex = 54;
            this.lbArgs.Text = "args";
            this.lbArgs.Visible = false;
            // 
            // tbArgs
            // 
            this.tbArgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbArgs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tbArgs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbArgs.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tbArgs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbArgs.Location = new System.Drawing.Point(41, 62);
            this.tbArgs.Name = "tbArgs";
            this.tbArgs.Size = new System.Drawing.Size(339, 15);
            this.tbArgs.TabIndex = 53;
            this.tbArgs.Tag = "color:dark2";
            this.tbArgs.Visible = false;
            // 
            // lbExecution
            // 
            this.lbExecution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbExecution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.lbExecution.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbExecution.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lbExecution.Location = new System.Drawing.Point(14, 38);
            this.lbExecution.Margin = new System.Windows.Forms.Padding(0);
            this.lbExecution.Name = "lbExecution";
            this.lbExecution.Padding = new System.Windows.Forms.Padding(2, 2, 1, 1);
            this.lbExecution.Size = new System.Drawing.Size(282, 21);
            this.lbExecution.TabIndex = 42;
            this.lbExecution.Tag = "color:dark2";
            this.lbExecution.Text = "No execution set";
            this.lbExecution.Visible = false;
            // 
            // pnSideBar
            // 
            this.pnSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnSideBar.Controls.Add(this.lbTargetStatus);
            this.pnSideBar.Controls.Add(this.label2);
            this.pnSideBar.Controls.Add(this.btnClearAllBackups);
            this.pnSideBar.Controls.Add(this.pnGlitchHarvesterOpen);
            this.pnSideBar.Controls.Add(this.btnRestoreBackup);
            this.pnSideBar.Controls.Add(this.btnResetBackup);
            this.pnSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnSideBar.Name = "pnSideBar";
            this.pnSideBar.Size = new System.Drawing.Size(118, 438);
            this.pnSideBar.TabIndex = 174;
            this.pnSideBar.Tag = "color:dark3";
            // 
            // lbTargetStatus
            // 
            this.lbTargetStatus.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbTargetStatus.ForeColor = System.Drawing.Color.White;
            this.lbTargetStatus.Location = new System.Drawing.Point(9, 37);
            this.lbTargetStatus.Name = "lbTargetStatus";
            this.lbTargetStatus.Size = new System.Drawing.Size(110, 44);
            this.lbTargetStatus.TabIndex = 123;
            this.lbTargetStatus.Text = "No target selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 122;
            this.label2.Text = "Status";
            // 
            // btnClearAllBackups
            // 
            this.btnClearAllBackups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnClearAllBackups.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnClearAllBackups.FlatAppearance.BorderSize = 0;
            this.btnClearAllBackups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAllBackups.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnClearAllBackups.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnClearAllBackups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearAllBackups.Location = new System.Drawing.Point(0, 166);
            this.btnClearAllBackups.Name = "btnClearAllBackups";
            this.btnClearAllBackups.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnClearAllBackups.Size = new System.Drawing.Size(133, 34);
            this.btnClearAllBackups.TabIndex = 121;
            this.btnClearAllBackups.TabStop = false;
            this.btnClearAllBackups.Tag = "color:dark3";
            this.btnClearAllBackups.Text = "Clear All Backups";
            this.btnClearAllBackups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearAllBackups.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearAllBackups.UseVisualStyleBackColor = false;
            this.btnClearAllBackups.Visible = false;
            this.btnClearAllBackups.Click += new System.EventHandler(this.BtnClearAllBackups_Click);
            // 
            // pnGlitchHarvesterOpen
            // 
            this.pnGlitchHarvesterOpen.BackColor = System.Drawing.Color.Gray;
            this.pnGlitchHarvesterOpen.Location = new System.Drawing.Point(-19, 188);
            this.pnGlitchHarvesterOpen.Name = "pnGlitchHarvesterOpen";
            this.pnGlitchHarvesterOpen.Size = new System.Drawing.Size(23, 25);
            this.pnGlitchHarvesterOpen.TabIndex = 8;
            this.pnGlitchHarvesterOpen.Tag = "color:light1";
            this.pnGlitchHarvesterOpen.Visible = false;
            // 
            // btnRestoreBackup
            // 
            this.btnRestoreBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnRestoreBackup.Enabled = false;
            this.btnRestoreBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRestoreBackup.FlatAppearance.BorderSize = 0;
            this.btnRestoreBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreBackup.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnRestoreBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRestoreBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestoreBackup.Location = new System.Drawing.Point(0, 90);
            this.btnRestoreBackup.Name = "btnRestoreBackup";
            this.btnRestoreBackup.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnRestoreBackup.Size = new System.Drawing.Size(133, 34);
            this.btnRestoreBackup.TabIndex = 119;
            this.btnRestoreBackup.TabStop = false;
            this.btnRestoreBackup.Tag = "color:dark3";
            this.btnRestoreBackup.Text = "Restore Backup";
            this.btnRestoreBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestoreBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestoreBackup.UseVisualStyleBackColor = false;
            this.btnRestoreBackup.Click += new System.EventHandler(this.BtnRestoreBackup_Click);
            // 
            // btnResetBackup
            // 
            this.btnResetBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnResetBackup.Enabled = false;
            this.btnResetBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnResetBackup.FlatAppearance.BorderSize = 0;
            this.btnResetBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetBackup.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnResetBackup.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnResetBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetBackup.Location = new System.Drawing.Point(0, 128);
            this.btnResetBackup.Name = "btnResetBackup";
            this.btnResetBackup.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnResetBackup.Size = new System.Drawing.Size(133, 34);
            this.btnResetBackup.TabIndex = 120;
            this.btnResetBackup.TabStop = false;
            this.btnResetBackup.Tag = "color:dark3";
            this.btnResetBackup.Text = "Reset Backup";
            this.btnResetBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetBackup.UseVisualStyleBackColor = false;
            this.btnResetBackup.Click += new System.EventHandler(this.BtnResetBackup_Click);
            // 
            // cbSelectedExecution
            // 
            this.cbSelectedExecution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSelectedExecution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cbSelectedExecution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectedExecution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSelectedExecution.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbSelectedExecution.ForeColor = System.Drawing.Color.White;
            this.cbSelectedExecution.FormattingEnabled = true;
            this.cbSelectedExecution.Location = new System.Drawing.Point(14, 14);
            this.cbSelectedExecution.Name = "cbSelectedExecution";
            this.cbSelectedExecution.Size = new System.Drawing.Size(282, 21);
            this.cbSelectedExecution.TabIndex = 117;
            this.cbSelectedExecution.TabStop = false;
            this.cbSelectedExecution.Tag = "color:dark2";
            this.cbSelectedExecution.Visible = false;
            this.cbSelectedExecution.SelectedIndexChanged += new System.EventHandler(this.CbSelectedExecution_SelectedIndexChanged);
            // 
            // pnTargetExecution
            // 
            this.pnTargetExecution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnTargetExecution.Controls.Add(this.btnEditExec);
            this.pnTargetExecution.Controls.Add(this.cbSelectedExecution);
            this.pnTargetExecution.Controls.Add(this.lbExecution);
            this.pnTargetExecution.Controls.Add(this.btnKillProcess);
            this.pnTargetExecution.Controls.Add(this.tbArgs);
            this.pnTargetExecution.Controls.Add(this.lbArgs);
            this.pnTargetExecution.Location = new System.Drawing.Point(575, 325);
            this.pnTargetExecution.Name = "pnTargetExecution";
            this.pnTargetExecution.Size = new System.Drawing.Size(395, 92);
            this.pnTargetExecution.TabIndex = 176;
            this.pnTargetExecution.Tag = "color:dark1";
            this.pnTargetExecution.Visible = false;
            // 
            // btnEditExec
            // 
            this.btnEditExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditExec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEditExec.FlatAppearance.BorderSize = 0;
            this.btnEditExec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditExec.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnEditExec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditExec.Location = new System.Drawing.Point(299, 14);
            this.btnEditExec.Name = "btnEditExec";
            this.btnEditExec.Size = new System.Drawing.Size(81, 21);
            this.btnEditExec.TabIndex = 118;
            this.btnEditExec.TabStop = false;
            this.btnEditExec.Tag = "color:dark2";
            this.btnEditExec.Text = "Edit Exec";
            this.btnEditExec.UseVisualStyleBackColor = false;
            this.btnEditExec.Click += new System.EventHandler(this.BtnEditExec_Click);
            // 
            // lbTargetExecution
            // 
            this.lbTargetExecution.AutoSize = true;
            this.lbTargetExecution.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lbTargetExecution.ForeColor = System.Drawing.Color.White;
            this.lbTargetExecution.Location = new System.Drawing.Point(577, 303);
            this.lbTargetExecution.Name = "lbTargetExecution";
            this.lbTargetExecution.Size = new System.Drawing.Size(95, 15);
            this.lbTargetExecution.TabIndex = 175;
            this.lbTargetExecution.Text = "Target execution";
            this.lbTargetExecution.Visible = false;
            // 
            // pnDosbox
            // 
            this.pnDosbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnDosbox.Controls.Add(this.cbCopyDriveNextBoot);
            this.pnDosbox.Controls.Add(this.cbCustomAutoexec);
            this.pnDosbox.Controls.Add(this.btnBrowseDriveFolder);
            this.pnDosbox.Controls.Add(this.button1);
            this.pnDosbox.Controls.Add(this.panel2);
            this.pnDosbox.Controls.Add(this.label6);
            this.pnDosbox.Controls.Add(this.tbAutoexec);
            this.pnDosbox.Controls.Add(this.rbGuestOS);
            this.pnDosbox.Controls.Add(this.rbDOS);
            this.pnDosbox.Controls.Add(this.label4);
            this.pnDosbox.Controls.Add(this.label1);
            this.pnDosbox.Controls.Add(this.btnRestoreDriveBackup);
            this.pnDosbox.Location = new System.Drawing.Point(136, 59);
            this.pnDosbox.Name = "pnDosbox";
            this.pnDosbox.Size = new System.Drawing.Size(401, 365);
            this.pnDosbox.TabIndex = 178;
            this.pnDosbox.Tag = "color:dark1";
            // 
            // cbCopyDriveNextBoot
            // 
            this.cbCopyDriveNextBoot.AutoSize = true;
            this.cbCopyDriveNextBoot.ForeColor = System.Drawing.Color.White;
            this.cbCopyDriveNextBoot.Location = new System.Drawing.Point(233, 140);
            this.cbCopyDriveNextBoot.Name = "cbCopyDriveNextBoot";
            this.cbCopyDriveNextBoot.Size = new System.Drawing.Size(158, 17);
            this.cbCopyDriveNextBoot.TabIndex = 64;
            this.cbCopyDriveNextBoot.Text = "Copy DRIVE to C: next boot";
            this.cbCopyDriveNextBoot.UseVisualStyleBackColor = true;
            // 
            // cbCustomAutoexec
            // 
            this.cbCustomAutoexec.AutoSize = true;
            this.cbCustomAutoexec.ForeColor = System.Drawing.Color.White;
            this.cbCustomAutoexec.Location = new System.Drawing.Point(233, 121);
            this.cbCustomAutoexec.Name = "cbCustomAutoexec";
            this.cbCustomAutoexec.Size = new System.Drawing.Size(154, 17);
            this.cbCustomAutoexec.TabIndex = 62;
            this.cbCustomAutoexec.Text = "Use custom Autoexec lines";
            this.cbCustomAutoexec.UseVisualStyleBackColor = true;
            // 
            // btnBrowseDriveFolder
            // 
            this.btnBrowseDriveFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBrowseDriveFolder.FlatAppearance.BorderSize = 0;
            this.btnBrowseDriveFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseDriveFolder.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnBrowseDriveFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBrowseDriveFolder.Location = new System.Drawing.Point(18, 129);
            this.btnBrowseDriveFolder.Name = "btnBrowseDriveFolder";
            this.btnBrowseDriveFolder.Size = new System.Drawing.Size(184, 23);
            this.btnBrowseDriveFolder.TabIndex = 61;
            this.btnBrowseDriveFolder.TabStop = false;
            this.btnBrowseDriveFolder.Tag = "color:dark2";
            this.btnBrowseDriveFolder.Text = "Browse DRIVE folder";
            this.btnBrowseDriveFolder.UseVisualStyleBackColor = false;
            this.btnBrowseDriveFolder.Click += new System.EventHandler(this.btnBrowseDriveFolder_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(180, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 60;
            this.button1.TabStop = false;
            this.button1.Tag = "color:dark2";
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.panel2.Location = new System.Drawing.Point(218, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 120);
            this.panel2.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Add post-mount lines to Autoexec";
            // 
            // tbAutoexec
            // 
            this.tbAutoexec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAutoexec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tbAutoexec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAutoexec.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tbAutoexec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbAutoexec.Location = new System.Drawing.Point(18, 78);
            this.tbAutoexec.Multiline = true;
            this.tbAutoexec.Name = "tbAutoexec";
            this.tbAutoexec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAutoexec.Size = new System.Drawing.Size(184, 39);
            this.tbAutoexec.TabIndex = 54;
            this.tbAutoexec.Tag = "color:dark2";
            // 
            // rbGuestOS
            // 
            this.rbGuestOS.AutoSize = true;
            this.rbGuestOS.ForeColor = System.Drawing.Color.White;
            this.rbGuestOS.Location = new System.Drawing.Point(233, 35);
            this.rbGuestOS.Name = "rbGuestOS";
            this.rbGuestOS.Size = new System.Drawing.Size(161, 17);
            this.rbGuestOS.TabIndex = 52;
            this.rbGuestOS.Text = "Guest OS (boots DRIVE.img)";
            this.rbGuestOS.UseVisualStyleBackColor = true;
            // 
            // rbDOS
            // 
            this.rbDOS.AutoSize = true;
            this.rbDOS.Checked = true;
            this.rbDOS.ForeColor = System.Drawing.Color.White;
            this.rbDOS.Location = new System.Drawing.Point(18, 35);
            this.rbDOS.Name = "rbDOS";
            this.rbDOS.Size = new System.Drawing.Size(156, 17);
            this.rbDOS.TabIndex = 51;
            this.rbDOS.TabStop = true;
            this.rbDOS.Text = "DOS (mounts DRIVE folder)";
            this.rbDOS.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Step 1 : Choose OS Type and setup Autoexec";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(230, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Load an initial drive image";
            // 
            // btnRestoreDriveBackup
            // 
            this.btnRestoreDriveBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRestoreDriveBackup.FlatAppearance.BorderSize = 0;
            this.btnRestoreDriveBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreDriveBackup.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnRestoreDriveBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRestoreDriveBackup.Location = new System.Drawing.Point(233, 77);
            this.btnRestoreDriveBackup.Name = "btnRestoreDriveBackup";
            this.btnRestoreDriveBackup.Size = new System.Drawing.Size(152, 39);
            this.btnRestoreDriveBackup.TabIndex = 48;
            this.btnRestoreDriveBackup.TabStop = false;
            this.btnRestoreDriveBackup.Tag = "color:dark2";
            this.btnRestoreDriveBackup.Text = "Restore drive_backup.img for Guest OS VM";
            this.btnRestoreDriveBackup.UseVisualStyleBackColor = false;
            this.btnRestoreDriveBackup.Click += new System.EventHandler(this.btnRestoreDriveBackup_Click);
            // 
            // btnLoadUncorrupted
            // 
            this.btnLoadUncorrupted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLoadUncorrupted.FlatAppearance.BorderSize = 0;
            this.btnLoadUncorrupted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadUncorrupted.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnLoadUncorrupted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLoadUncorrupted.Location = new System.Drawing.Point(250, 23);
            this.btnLoadUncorrupted.Name = "btnLoadUncorrupted";
            this.btnLoadUncorrupted.Size = new System.Drawing.Size(126, 56);
            this.btnLoadUncorrupted.TabIndex = 63;
            this.btnLoadUncorrupted.TabStop = false;
            this.btnLoadUncorrupted.Tag = "color:dark2";
            this.btnLoadUncorrupted.Text = "Load Backup State (Uncorrupted)";
            this.btnLoadUncorrupted.UseVisualStyleBackColor = false;
            this.btnLoadUncorrupted.Click += new System.EventHandler(this.btnLoadUncorrupted_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(289, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "Optional: Save/Load DRIVE State (Dosbox must be closed)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(335, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Optional: Load/Unload MEMORY file in RTC (Autoloads at savestate)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Start Dosbox and create a RAM Save Savestate";
            // 
            // btnDriveLoadState
            // 
            this.btnDriveLoadState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnDriveLoadState.FlatAppearance.BorderSize = 0;
            this.btnDriveLoadState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriveLoadState.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnDriveLoadState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDriveLoadState.Location = new System.Drawing.Point(159, 166);
            this.btnDriveLoadState.Name = "btnDriveLoadState";
            this.btnDriveLoadState.Size = new System.Drawing.Size(140, 23);
            this.btnDriveLoadState.TabIndex = 47;
            this.btnDriveLoadState.TabStop = false;
            this.btnDriveLoadState.Tag = "color:dark2";
            this.btnDriveLoadState.Text = "DRIVE Load State";
            this.btnDriveLoadState.UseVisualStyleBackColor = false;
            this.btnDriveLoadState.Click += new System.EventHandler(this.btnDriveLoadState_Click);
            // 
            // btnDriveSaveState
            // 
            this.btnDriveSaveState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnDriveSaveState.FlatAppearance.BorderSize = 0;
            this.btnDriveSaveState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriveSaveState.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnDriveSaveState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDriveSaveState.Location = new System.Drawing.Point(10, 166);
            this.btnDriveSaveState.Name = "btnDriveSaveState";
            this.btnDriveSaveState.Size = new System.Drawing.Size(140, 23);
            this.btnDriveSaveState.TabIndex = 46;
            this.btnDriveSaveState.TabStop = false;
            this.btnDriveSaveState.Tag = "color:dark2";
            this.btnDriveSaveState.Text = "DRIVE Save State";
            this.btnDriveSaveState.UseVisualStyleBackColor = false;
            this.btnDriveSaveState.Click += new System.EventHandler(this.btnDriveSaveState_Click);
            // 
            // btnKillDosbox
            // 
            this.btnKillDosbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnKillDosbox.FlatAppearance.BorderSize = 0;
            this.btnKillDosbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKillDosbox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnKillDosbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnKillDosbox.Location = new System.Drawing.Point(142, 23);
            this.btnKillDosbox.Name = "btnKillDosbox";
            this.btnKillDosbox.Size = new System.Drawing.Size(99, 23);
            this.btnKillDosbox.TabIndex = 45;
            this.btnKillDosbox.TabStop = false;
            this.btnKillDosbox.Tag = "color:dark2";
            this.btnKillDosbox.Text = "Kill Dosbox";
            this.btnKillDosbox.UseVisualStyleBackColor = false;
            this.btnKillDosbox.Click += new System.EventHandler(this.btnKillDosbox_Click);
            // 
            // btnRamLoadState
            // 
            this.btnRamLoadState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRamLoadState.FlatAppearance.BorderSize = 0;
            this.btnRamLoadState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRamLoadState.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnRamLoadState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRamLoadState.Location = new System.Drawing.Point(142, 56);
            this.btnRamLoadState.Name = "btnRamLoadState";
            this.btnRamLoadState.Size = new System.Drawing.Size(99, 23);
            this.btnRamLoadState.TabIndex = 44;
            this.btnRamLoadState.TabStop = false;
            this.btnRamLoadState.Tag = "color:dark2";
            this.btnRamLoadState.Text = "RAM Load State";
            this.btnRamLoadState.UseVisualStyleBackColor = false;
            this.btnRamLoadState.Click += new System.EventHandler(this.btnRamLoadState_Click);
            // 
            // btnRamSaveState
            // 
            this.btnRamSaveState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRamSaveState.FlatAppearance.BorderSize = 0;
            this.btnRamSaveState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRamSaveState.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnRamSaveState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRamSaveState.Location = new System.Drawing.Point(9, 56);
            this.btnRamSaveState.Name = "btnRamSaveState";
            this.btnRamSaveState.Size = new System.Drawing.Size(124, 23);
            this.btnRamSaveState.TabIndex = 43;
            this.btnRamSaveState.TabStop = false;
            this.btnRamSaveState.Tag = "color:dark2";
            this.btnRamSaveState.Text = "RAM Save State";
            this.btnRamSaveState.UseVisualStyleBackColor = false;
            this.btnRamSaveState.Click += new System.EventHandler(this.btnRamSaveState_Click);
            // 
            // btnStartDosbox
            // 
            this.btnStartDosbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnStartDosbox.FlatAppearance.BorderSize = 0;
            this.btnStartDosbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartDosbox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnStartDosbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStartDosbox.Location = new System.Drawing.Point(10, 23);
            this.btnStartDosbox.Name = "btnStartDosbox";
            this.btnStartDosbox.Size = new System.Drawing.Size(123, 23);
            this.btnStartDosbox.TabIndex = 42;
            this.btnStartDosbox.TabStop = false;
            this.btnStartDosbox.Tag = "color:dark2";
            this.btnStartDosbox.Text = "Start/Restart Dosbox";
            this.btnStartDosbox.UseVisualStyleBackColor = false;
            this.btnStartDosbox.Click += new System.EventHandler(this.btnStartDosbox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(133, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 179;
            this.label3.Text = "Dosbox Controls";
            // 
            // pnBasicDosbox
            // 
            this.pnBasicDosbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnBasicDosbox.Controls.Add(this.btnShowAdvanced);
            this.pnBasicDosbox.Controls.Add(this.button4);
            this.pnBasicDosbox.Controls.Add(this.label11);
            this.pnBasicDosbox.Controls.Add(this.button3);
            this.pnBasicDosbox.Controls.Add(this.button2);
            this.pnBasicDosbox.Controls.Add(this.label10);
            this.pnBasicDosbox.Location = new System.Drawing.Point(138, 227);
            this.pnBasicDosbox.Name = "pnBasicDosbox";
            this.pnBasicDosbox.Size = new System.Drawing.Size(396, 195);
            this.pnBasicDosbox.TabIndex = 119;
            this.pnBasicDosbox.Tag = "color:dark1";
            // 
            // btnShowAdvanced
            // 
            this.btnShowAdvanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnShowAdvanced.FlatAppearance.BorderSize = 0;
            this.btnShowAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAdvanced.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnShowAdvanced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShowAdvanced.Location = new System.Drawing.Point(216, 167);
            this.btnShowAdvanced.Name = "btnShowAdvanced";
            this.btnShowAdvanced.Size = new System.Drawing.Size(176, 23);
            this.btnShowAdvanced.TabIndex = 67;
            this.btnShowAdvanced.TabStop = false;
            this.btnShowAdvanced.Tag = "color:dark2";
            this.btnShowAdvanced.Text = "Advanced Dosbox Commands";
            this.btnShowAdvanced.UseVisualStyleBackColor = false;
            this.btnShowAdvanced.Click += new System.EventHandler(this.btnShowAdvanced_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(16, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(228, 23);
            this.button4.TabIndex = 66;
            this.button4.TabStop = false;
            this.button4.Tag = "color:dark2";
            this.button4.Text = "Hook Memory state and connect to RTC";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnRamSaveState_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(13, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Step 3 : Hook RTC to Dosbox";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(145, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 64;
            this.button3.TabStop = false;
            this.button3.Tag = "color:dark2";
            this.button3.Text = "Kill Dosbox";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnKillDosbox_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(16, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 58;
            this.button2.TabStop = false;
            this.button2.Tag = "color:dark2";
            this.button2.Text = "Start/Restart Dosbox";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnStartDosbox_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(298, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Step 2 : Start Dosbox and let it load out of COMMAND/BOOT";
            // 
            // pnAdvancedDosbox
            // 
            this.pnAdvancedDosbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnAdvancedDosbox.Controls.Add(this.label7);
            this.pnAdvancedDosbox.Controls.Add(this.btnLoadUncorrupted);
            this.pnAdvancedDosbox.Controls.Add(this.btnStartDosbox);
            this.pnAdvancedDosbox.Controls.Add(this.btnRamSaveState);
            this.pnAdvancedDosbox.Controls.Add(this.btnRamLoadState);
            this.pnAdvancedDosbox.Controls.Add(this.btnKillDosbox);
            this.pnAdvancedDosbox.Controls.Add(this.btnDriveSaveState);
            this.pnAdvancedDosbox.Controls.Add(this.label9);
            this.pnAdvancedDosbox.Controls.Add(this.btnDriveLoadState);
            this.pnAdvancedDosbox.Controls.Add(this.btnLoadTarget);
            this.pnAdvancedDosbox.Controls.Add(this.btnUnloadTarget);
            this.pnAdvancedDosbox.Controls.Add(this.label8);
            this.pnAdvancedDosbox.Location = new System.Drawing.Point(985, 170);
            this.pnAdvancedDosbox.Name = "pnAdvancedDosbox";
            this.pnAdvancedDosbox.Size = new System.Drawing.Size(396, 195);
            this.pnAdvancedDosbox.TabIndex = 120;
            this.pnAdvancedDosbox.Tag = "color:dark1";
            // 
            // StubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(550, 438);
            this.Controls.Add(this.pnAdvancedDosbox);
            this.Controls.Add(this.pnBasicDosbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnDosbox);
            this.Controls.Add(this.pnTargetExecution);
            this.Controls.Add(this.lbTargetExecution);
            this.Controls.Add(this.pnSideBar);
            this.Controls.Add(this.btnTargetSettings);
            this.Controls.Add(this.pnTarget);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StubForm";
            this.Tag = "color:dark2";
            this.Text = "DosboxStub ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StubForm_FormClosing);
            this.Load += new System.EventHandler(this.StubForm_Load);
            this.pnTarget.ResumeLayout(false);
            this.pnSideBar.ResumeLayout(false);
            this.pnSideBar.PerformLayout();
            this.pnTargetExecution.ResumeLayout(false);
            this.pnTargetExecution.PerformLayout();
            this.pnDosbox.ResumeLayout(false);
            this.pnDosbox.PerformLayout();
            this.pnBasicDosbox.ResumeLayout(false);
            this.pnBasicDosbox.PerformLayout();
            this.pnAdvancedDosbox.ResumeLayout(false);
            this.pnAdvancedDosbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnTarget;
        public System.Windows.Forms.Button btnTargetSettings;
        public System.Windows.Forms.Label lbArgs;
        public System.Windows.Forms.TextBox tbArgs;
        public System.Windows.Forms.Label lbExecution;
        private System.Windows.Forms.Panel pnSideBar;
        public System.Windows.Forms.Button btnClearAllBackups;
        internal System.Windows.Forms.Panel pnGlitchHarvesterOpen;
        public System.Windows.Forms.Button btnRestoreBackup;
        public System.Windows.Forms.Button btnResetBackup;
        private System.Windows.Forms.Button btnKillProcess;
        public System.Windows.Forms.ComboBox cbSelectedExecution;
        private System.Windows.Forms.Panel pnTargetExecution;
        public System.Windows.Forms.Label lbTargetExecution;
        public System.Windows.Forms.Button btnLoadTarget;
        public System.Windows.Forms.Label lbTarget;
        private System.Windows.Forms.Button btnEditExec;
        public System.Windows.Forms.Label lbTargetStatus;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbTargetType;
        private System.Windows.Forms.Panel pnDosbox;
        private System.Windows.Forms.Button btnRestoreDriveBackup;
        private System.Windows.Forms.Button btnDriveLoadState;
        private System.Windows.Forms.Button btnDriveSaveState;
        private System.Windows.Forms.Button btnKillDosbox;
        private System.Windows.Forms.Button btnRamLoadState;
        private System.Windows.Forms.Button btnRamSaveState;
        private System.Windows.Forms.Button btnStartDosbox;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbAutoexec;
        private System.Windows.Forms.RadioButton rbGuestOS;
        private System.Windows.Forms.RadioButton rbDOS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBrowseDriveFolder;
        private System.Windows.Forms.CheckBox cbCustomAutoexec;
        private System.Windows.Forms.Button btnLoadUncorrupted;
        private System.Windows.Forms.CheckBox cbCopyDriveNextBoot;
        private System.Windows.Forms.Panel pnBasicDosbox;
        private System.Windows.Forms.Button btnShowAdvanced;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnAdvancedDosbox;
        public System.Windows.Forms.Button btnUnloadTarget;
    }
}

