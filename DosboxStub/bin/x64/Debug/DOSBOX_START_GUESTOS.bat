@echo off
cd DOSBOX
taskkill /F /IM dosbox-x.exe 
start dosbox-x -conf guestos.conf
exit