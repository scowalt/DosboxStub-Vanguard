Dosbox-x corruptor POC/Prototype

How get the Windows 98 VM running

First of all, you need to reload a drive backup. run the "DRIVE BACKUP RESTORE.bat" batch file
Then, you can start the VM by running the "!!! START WINDOWS 98.bat"
Your VM is ready to use

-----------------------------------------------------------------------
VM SAVESTATES:
At any point, you may create a VM savestate from the menu Capture -> Save State
You can also reload your Save State with Capture -> Load State

Dosbox-x lets you choose many savestate slots but for the automation batch files, we only use State 1
If you change your selected slot, these batch files will not work properly.
-----------------------------------------------------------------------

DRIVE SAVESTATES:
I have added 2 batch files "DRIVE STATE LOAD.bat" and "DRIVE STATE SAVE.bat" so you can save the state of the hard drive.
At any point if your VM is unusable and you need to restore it to default, you can run "DRIVE BACKUP RESTORE.bat"


-----------------------------------------------------------------------
CORRUPTING:

This is going to be Semi-Realtime hooking via uncompressed savestates.
Just like when we used to hook to Dolphin with WGH, this is a modded version of Dosbox-x that generates uncompressed savestates.

However, Dosbox-x really loves to zip its savestate components so we can not hook to the inner components just yet.

I have provided 2 batch files to automate this: "RAM STATE UNPACK.bat" and "RAM STATE REPACK.bat".

RAM STATE UNPACK.bat takes the generated 1.sav file, and extracts it to the "1" folder.
You can get to that folder by going to DOSBOX -> save -> 1

The file you will want to hook with FileStub is called MEMORY. You might want to generate a VMD that excludes the 10 first bytes,
which are going to be a gzip header for the MEMORY file (you don't want to corrupt that).

Set FileStub's Target Execution to "Execute other file" and select the "RAM STATE REPACK.bat" batch file.
Every time you will press Corrupt in RTC, it will repack the MEMORY file back into the savestate.

Now, all you have to do is Load State in dosbox and your corrupted savestate will load.

-------------------------------------------------------------------------
TROUBLESHOOTING:

Restoring backup in FileStub:
When you restore a backup in FileStub, it doesn't automatically repack the uncorrupted data back in the savestate. You will need to
execute "RAM STATE REPACK.bat" before loading the uncorrupted state back. Otherwise, you can also try corrupting with intensity 1, since there's
not a lot of chance of it killing windows, but Restore Backup is much safer.

Blue Screens: 
If you get a Blue Screen in the VM, don't load a Savestate while either on the Blue Screen or on a 16-bit messagebox.
Try to get out of the blue screen by pressing Enter and going through the many error pages. If you manage to get back in the 32-bit UI,
you MAY be able to load a savestate. If it doesn't work, you'll get the OS in a weird unresponsive state

OS UNRESPONSIVE: 
After loading a savestate, it is possible that Windows gets in a weird limbo where the start menu won't have any icons
and hovering a window over desktop icons will reveal white icons. If that happens, you must Reboot the entire VM and let it reload windows entirely.

LOADING SAVESTATES TOO EARLY: 
Always wait for Windows to show the desktop icons before loading a savestate. If you load a savestate too early, you'll
get the situation described in "OS UNRESPONSIVE".


