using Kf.CANetCore31.Core.Application;
using Kf.CANetCore31.Core.Application.Cqs.Queries.GetPeople;
using Kf.CANetCore31.Infrastructure.Persistence.Ef;
using Kf.CANetCore31.Presentation.Desktop.Hosting.Extensions;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Kf.CANetCore31.Presentation.Desktop.ConsoleApp
{
    public sealed class Program
    {
        public static void Main(string[] args)
            => ConsoleHostBuilder.CreateAndRunApplication<Program>(
                arguments: args,
                configureServicesDelegate: (hostingContext, services) => {
                    services.AddAndConfigureApplication();
                    services.AddAndConfigureSqlServerPersistence(hostingContext.Configuration);
                });

        public Program(
            ILogger<Program> logger,
            IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        private readonly ILogger<Program> _logger;
        private readonly IMediator _mediator;

        public async Task Run()
        {
            _logger.LogInformation($"Starting application.");

            var people = await _mediator.Send(new GetPeopleQuery());

            _logger.LogInformation($"Ended application.");
        }
    }
}
