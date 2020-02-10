using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Kf.CANetCore31.Core.Application.Cqs.Queries.GetPeople
{
    public sealed class GetPeopleQuery
        : IRequest<IEnumerable<PersonViewModel>>
    { }

    public sealed class GetPeopleQueryHandler
        : ReadOnlyRequestHandler<GetPeopleQuery, IEnumerable<PersonViewModel>>
    {
        public GetPeopleQueryHandler(
            IReadOnlyApplicationDbContext db,
            IMapper mapper)
            : base(db, mapper)
        { }

        public override async Task<IEnumerable<PersonViewModel>> Handle(
            GetPeopleQuery request,
            CancellationToken cancellationToken)
            => await _db.People
                .AsNoTracking()
                .ProjectTo<PersonViewModel>(_mapper)
                .ToListAsync();
    }
}
