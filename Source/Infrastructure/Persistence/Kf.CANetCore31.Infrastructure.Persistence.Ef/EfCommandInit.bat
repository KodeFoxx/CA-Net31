ECHO OFF

SET DOTNET_ENVIRONMENT=%1
IF NOT DEFINED DOTNET_ENVIRONMENT (SET DOTNET_ENVIRONMENT=Development)
SET "startup_project=..\Kf.CANetCore31.Infrastructure.Persistence.Ef.MigrationsRunner\Kf.CANetCore31.Infrastructure.Persistence.Ef.MigrationsRunner.csproj"
ECHO DOTNET_ENVIRONMENT=%DOTNET_ENVIRONMENT%
ECHO startup_project=%startup_project%

ECHO ON