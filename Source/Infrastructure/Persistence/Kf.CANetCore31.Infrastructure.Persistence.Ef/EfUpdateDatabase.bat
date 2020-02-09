CALL EfCommandInit.bat %1

dotnet ef database update --startup-project %startup_project%

CALL EfCommandCleanup.bat