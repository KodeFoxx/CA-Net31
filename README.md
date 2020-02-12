![CI](https://github.com/KodeFoxx/Kf.CleanArchitectureTemplate.NetCore31/workflows/CI/badge.svg?branch=master)
**NOTE** build currently fails due to https://github.com/dotnet/runtime/issues/3832

# KodeFoxx Clean Architecture Template for .Net Core 3.1.x
- Hosting
  - [ConsoleHostBuilder](https://github.com/KodeFoxx/Kf.CleanArchitectureTemplate.NetCore31/blob/master/Source/Presentation/Desktop/Kf.CANetCore31.Presentation.Desktop.Hosting.Extensions/ConsoleHostBuilder.cs#L19) with [example usage](https://github.com/KodeFoxx/Kf.CleanArchitectureTemplate.NetCore31/blob/master/Source/Presentation/Desktop/Kf.CANetCore31.Presentation.Desktop.ConsoleApp/Program.cs#L8).
- Dependency Injection
- MediatR
  - Commands and Queries
  - Pipelinebehavior
- FluentValidation
- Automapper
- Serilog
- Entity Framework Core
  - Migrations
  - Export to SQL

## Long path issues
If you're having troubles with long paths, then please use VS 2019+ and do the following
- Edit the registry key to enable long path behaviour, setting the value to 1. This is a new opt-in feature for Windows 10: `HKLM\SYSTEM\CurrentControlSet\Control\FileSystem LongPathsEnabled (Type: REG_DWORD)`
- Also check the settings in your Local Group Policy Editor at `Local Computer Policy: Computer Configuration: Administrative Templates: All Settings`. In this location you can find `Enable Win32 long paths`. (see article at: https://blogs.msdn.microsoft.com/jeremykuhne/2016/07/30/net-4-6-2-and-long-paths-on-windows-10/).
