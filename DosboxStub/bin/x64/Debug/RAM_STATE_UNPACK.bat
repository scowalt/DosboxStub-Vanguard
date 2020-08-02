@echo off
echo.
echo ===============================
echo       UNPACKING RAM STATE
echo ===============================
echo.
echo Please ignore any errors below.
echo.
echo.

cd DOSBOX
cd save
RD /s /q 1 
mkdir 1  
copy 1.sav 1 
cd 1
..\7za e -tzip -mx0 1.sav 
del 1.sav 
exit