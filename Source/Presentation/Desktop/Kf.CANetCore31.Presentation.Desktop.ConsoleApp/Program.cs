using Kf.CANetCore31.Presentation.Desktop.Hosting.Extensions;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Kf.CANetCore31.Presentation.Desktop.ConsoleApp
{
    public sealed class Program
    {
        public static void Main(string[] args)
            => ConsoleHostBuilder.CreateAndRunApplication<Program>(args);

        private readonly ILogger<Program> _logger;

        public Program(ILogger<Program> logger)
            => _logger = logger;

        public async Task Run()
        {
            _logger.LogInformation($"Starting application.");
            await Task.Run(() => Console.WriteLine("Hello, world!"));
            _logger.LogInformation($"Ended application.");
        }
    }
}
