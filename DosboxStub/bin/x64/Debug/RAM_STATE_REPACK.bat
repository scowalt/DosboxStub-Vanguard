@echo off
echo.
echo ===============================
echo      REPACKING RAM STATE 1
echo ===============================
echo.
echo Please ignore any errors below.
echo.
echo.

cd DOSBOX
cd save
del 1.sav 
cd 1
del 1.sav 
..\7za a -tzip -mx0 1.sav * 
move 1.sav ..\ 