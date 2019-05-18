@echo off
echo.
set/p mensaje= Escribe tu mensaje: 
git add .
git commit -m "%mensaje%"
git push