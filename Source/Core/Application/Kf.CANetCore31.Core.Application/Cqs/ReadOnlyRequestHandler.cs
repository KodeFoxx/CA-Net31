using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Kf.CANetCore31.Core.Application.Cqs
{
    public abstract class ReadOnlyRequestHandler<TRequest, TResponse>
        : IRequestHandler<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        public ReadOnlyRequestHandler(
            IReadOnlyApplicationDbContext db,
            IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        protected readonly IReadOnlyApplicationDbContext _db;
        protected readonly IMapper _mapper;

        public abstract Task<TResponse> Handle(
            TRequest request,
            CancellationToken cancellationToken);
    }
}
