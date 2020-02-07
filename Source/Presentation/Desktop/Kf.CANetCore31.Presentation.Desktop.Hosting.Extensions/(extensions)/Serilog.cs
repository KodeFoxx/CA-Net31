using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;

namespace Kf.CANetCore31.Presentation.Desktop.Hosting.Extensions
{
    public static class Serilog
    {
        public static ILoggingBuilder AddAndConfigureSerilog(
            this ILoggingBuilder loggingBuilder)
        {
            loggingBuilder.ClearProviders();

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .Enrich.FromLogContext()
                .WriteTo.Console(theme: AnsiConsoleTheme.Literate)
                .CreateLogger();

            loggingBuilder.AddSerilog(dispose: true);

            return loggingBuilder;
        }
    }
}
