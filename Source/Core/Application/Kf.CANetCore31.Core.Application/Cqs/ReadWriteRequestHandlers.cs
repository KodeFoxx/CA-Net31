using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Kf.CANetCore31.Core.Application.Cqs
{
    public abstract class ReadWriteRequestHandler<TRequest, TResponse>
        : IRequestHandler<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        public ReadWriteRequestHandler(
            IReadWriteApplicationDbContext db,
            IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        protected readonly IReadWriteApplicationDbContext _db;
        private readonly IMapper _mapper;

        public abstract Task<TResponse> Handle(
            TRequest request,
            CancellationToken cancellationToken);
    }

    public abstract class ReadWriteRequestHandler<TRequest>
        : IRequestHandler<TRequest>
        where TRequest : IRequest
    {
        public ReadWriteRequestHandler(
            IReadWriteApplicationDbContext db,
            IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        protected readonly IReadWriteApplicationDbContext _db;
        private readonly IMapper _mapper;

        public abstract Task<Unit> Handle(
            TRequest request,
            CancellationToken cancellationToken);
    }
}
