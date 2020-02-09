ECHO OFF

SET %startup-project%=..\KfCANetCore31.Infrastructure.Persistence.Ef.MigrationsRunner\KfCANetCore31.Infrastructure.Persistence.Ef.MigrationsRunner.csproj
SET DOTNET_ENVIRONMENT=%1
IF NOT DEFINED DOTNET_ENVIRONMENT (SET DOTNET_ENVIRONMENT=Development)
ECHO DOTNET_ENVIRONMENT=%DOTNET_ENVIRONMENT%

ECHO ON