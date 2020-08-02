@echo off

cd DOSBOX
cd save
del 1.sav 
cd 1
del 1.sav 
..\7za a -tzip -mx0 1.sav * 
move 1.sav ..\ 
cd..
cd..
start LoadState.exe
exit