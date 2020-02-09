CALL EfCommandInit.bat %1

FOR /f "tokens=2 delims==" %%a in ('wmic OS Get localdatetime /value') do SET "dt=%%a"
SET "YY=%dt:~2,2%" & SET "YYYY=%dt:~0,4%" & SET "MM=%dt:~4,2%" & SET "DD=%dt:~6,2%"
SET "HH=%dt:~8,2%" & SET "Min=%dt:~10,2%" & SET "Sec=%dt:~12,2%"
SET "datestamp=%YYYY%%MM%%DD%" & SET "timestamp=%HH%%Min%%Sec%"
SET "fullstamp=%YYYY%-%MM%-%DD%_%HH%-%Min%-%Sec%

dotnet ef migrations script --startup-project %startup_project% --output SqlScripts\%fullstamp%.sql

CALL EfCommandCleanup.bat