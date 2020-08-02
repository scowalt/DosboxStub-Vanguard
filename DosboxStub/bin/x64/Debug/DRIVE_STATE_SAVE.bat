@echo off
echo.
echo ===============================
echo       SAVING DRIVE STATE
echo ===============================
echo.
echo Please ignore any errors below.
echo.
echo.

cd DOSBOX
taskkill /F /IM dosbox-x.exe 
del drive_state.img 
copy drive.img drive_state.img 
exit