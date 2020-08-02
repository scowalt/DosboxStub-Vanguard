@echo off
echo.
echo ===============================
echo       LOADING DRIVE STATE
echo ===============================
echo.
echo Please ignore any errors below.
echo.
echo.

cd DOSBOX
taskkill /F /IM dosbox-x.exe 
del drive.img 
copy drive_state.img drive.img 
exit