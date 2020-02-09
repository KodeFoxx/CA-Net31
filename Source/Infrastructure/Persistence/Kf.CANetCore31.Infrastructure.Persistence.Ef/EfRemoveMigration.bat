CALL EfCommandInit.bat %1

dotnet ef migrations remove --startup-project %startup_project%

CALL EfCommandCleanup.bat