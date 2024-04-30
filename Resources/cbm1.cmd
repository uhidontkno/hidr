@echo off
echo Command Prompt
echo.
:a
set /p comm="%CD%>"
%comm%
goto a