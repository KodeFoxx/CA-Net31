using Kf.CANetCore31.Core.Application;
using Kf.CANetCore31.Core.Application.Cqs.Commands.AddPerson;
using Kf.CANetCore31.Core.Application.Cqs.Queries.GetPeople;
using Kf.CANetCore31.Infrastructure.Persistence.Ef;
using Kf.CANetCore31.Presentation.Desktop.Hosting.Extensions;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kf.CANetCore31.Presentation.Desktop.ConsoleApp
{
    public sealed class Program
    {
        public static void Main(string[] args)
            => ConsoleHostBuilder.CreateAndRunApplication<Program>(
                arguments: args,
                configureServicesDelegate: (hostingContext, services) =>
                {
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

            var amountOfPeople = 0;
            while (amountOfPeople <= 0)
            {
                var people = await GetPeople();
                LogPeople(people);
                amountOfPeople = people.Count();

                if (amountOfPeople == 0)
                    await AddPerson();
            }

            _logger.LogInformation($"Ended application.");
        }

        private async Task<IEnumerable<PersonViewModel>> GetPeople()
            => (await _mediator.Send(new GetPeopleQuery())).IfNullThenEmpty();
        private async Task AddPerson()
            => await _mediator.Send(new AddPersonCommand("Yves", "Schelpe"));
        private void LogPeople(IEnumerable<PersonViewModel> people)
        {
            var amountOfPeople = people.Count();
            var firstTenPeople = String.Join(", ", people.Select(p => $"{p.Number}: '{p.FirstName} {p.LastName}'"));
            if (amountOfPeople == 0)
                _logger.LogWarning("Found #{amountOfPeople} people.", amountOfPeople);
            else
                _logger.LogInformation("Found #{amountOfPeople} people: {people}", amountOfPeople, firstTenPeople);
        }
    }
}
