EfCommandInit.bat %2

dotnet ef migrations add %1 --startup-project %startup_project%

EfCommandCleanup.bat