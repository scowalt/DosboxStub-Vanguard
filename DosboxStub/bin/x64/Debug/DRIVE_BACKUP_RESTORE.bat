@echo off
echo.
echo ===============================
echo     RESTORING DRIVE BACKUP
echo ===============================
echo.
echo Please ignore any errors below.
echo.
echo.

cd DOSBOX
taskkill /F /IM dosbox-x.exe
del drive.img
copy drive_backup.img drive.img
exit