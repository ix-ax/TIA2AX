for %%I in (.) do set CurrDirName=%%~nxI
set "tiaProjectPath=%CD%\%CurrDirName%.ap19"
for %%I in ("%CD%\..\..") do set "exportPath=%%~fI\expected\%CurrDirName%"
for %%I in ("%CD%\..\..\..\..") do set "main=%%~fI"
rem fill the path to the folder where tia2ax.exe is located
set "tia2axPath=%main%\src\tia2ax\V19_0\bin\Debug\net4.8"
set "params=-x %tiaProjectPath% -o %exportPath%"
start /wait "ax2tia" /D "%tia2axPath%" "V19_0_tia2ax.exe" %params%
exit


