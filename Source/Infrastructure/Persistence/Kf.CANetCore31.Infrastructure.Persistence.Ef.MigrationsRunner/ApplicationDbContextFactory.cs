using Kf.CANetCore31.Presentation.Desktop.Hosting.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace Kf.CANetCore31.Infrastructure.Persistence.Ef.MigrationsRunner
{
    public sealed class ApplicationDbContextFactory
        : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContextFactory()
        {
            _host = ConsoleHostBuilder.CreateHost<ApplicationDbContext>(new string[] { });
            _logger = GetService<ILogger<ApplicationDbContextFactory>>();
            _configuration = GetService<IConfiguration>();

            Console.WriteLine();
            Console.WriteLine();

            _logger.LogInformation(
                "Initialized '{type}' in environment '{environment}' with connection string set to '{connectionString}'.",
                nameof(ApplicationDbContextFactory), GetCurrentEnvironment(), GetConnectionString());
        }

        private readonly IHost _host;
        private readonly IConfiguration _configuration;
        private readonly ILogger<ApplicationDbContextFactory> _logger;

        public ApplicationDbContext CreateDbContext(string[] args)
        {
            if (args.IfNullThenEmpty()?.Length() == 0)
                _logger.LogTrace("No arguments given.");
            else
                _logger.LogTrace("Given arguments: '{args}'.", String.Join(" ", args));

            if (DoesNotHaveConnectionString())
            {
                _logger.LogError(
                    "No connection string found to initialize database context '{dbContext}'. Ending application now, you will notice an error that an object was not able to be constructed.",
                    nameof(ApplicationDbContext)
                );
                return null;
            }

            _logger.LogTrace("Start building options object...");
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(GetConnectionString())
                .Options;
            _logger.LogTrace("Completed building options object.");

            if (ContinueWithAction())
                return new ApplicationDbContext(options);

            return null;
        }

        private bool HasConnectionString()
            => !DoesNotHaveConnectionString();
        private bool DoesNotHaveConnectionString()
            => GetConnectionString() == Null.NullString;

        private T GetService<T>()
            => (T)_host.Services.GetService(typeof(T));

        private string GetCurrentEnvironment()
            => Environment
                .GetEnvironmentVariable("DOTNET_ENVIRONMENT")
                .IfNullOrWhiteSpaceThen(Null.NullString);
        private string GetConnectionString()
            => _configuration
                .GetConnectionString(nameof(ApplicationDbContext))
                .IfNullOrWhiteSpaceThen(Null.NullString);

        private bool ContinueWithAction()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Do you wish to continue this command on ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"environment '{GetCurrentEnvironment()}'");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"? Then press ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"key 'Y' to confirm");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($", or ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"key 'N' to abort this action");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($". ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"If you would like to change the environment, then add a value for the environment variable after the the batch command as last parameter, choose between: 'Local', 'Development', 'Qa' or 'Production'. E.g.: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"\"X:\\> EfCommand.bat ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Production");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"\"");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($", this would result the environment being set to 'Production'.");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" >> Your choice (");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Y");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("N");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("): ");
            Console.ForegroundColor = ConsoleColor.White;
            var choice = Console.ReadKey();
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine();

            if (choice.Key == ConsoleKey.Y)
                return true;

            return false;
        }
    }
}
