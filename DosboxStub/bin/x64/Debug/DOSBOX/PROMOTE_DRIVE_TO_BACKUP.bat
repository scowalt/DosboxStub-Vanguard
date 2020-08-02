@echo off
taskkill /F /IM dosbox-x.exe
del guestos_backup.img
copy guestos.img guestos_backup.img
exit