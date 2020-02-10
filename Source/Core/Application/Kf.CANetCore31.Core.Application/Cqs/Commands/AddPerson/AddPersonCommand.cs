using AutoMapper;
using Kf.CANetCore31.Core.Domain.People;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Kf.CANetCore31.Core.Application.Cqs.Commands.AddPerson
{
    public sealed class AddPersonCommand
        : IRequest
    {
        public AddPersonCommand(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }
    }

    public sealed class AddPersonCommandHandler
        : ReadWriteRequestHandler<AddPersonCommand>
    {
        public AddPersonCommandHandler(
            IReadWriteApplicationDbContext db,
            IMapper mapper)
            : base(db, mapper)
        { }

        public override async Task<Unit> Handle(
            AddPersonCommand request,
            CancellationToken cancellationToken)
        {
            _db.People.Add(Person.Create(
                Name.Create(request.FirstName, request.LastName))
            );

            await _db.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
