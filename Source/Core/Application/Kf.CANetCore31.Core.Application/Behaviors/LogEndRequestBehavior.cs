using MediatR.Pipeline;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Kf.CANetCore31.Core.Application.Behaviors
{
    public sealed class LogEndRequestBehavior<TRequest, TResponse>
        : LogRequestBehavior<TRequest>, IRequestPostProcessor<TRequest, TResponse>
    {
        public LogEndRequestBehavior(ILogger<TRequest> logger)
            : base(logger)
        { }

        public Task Process(
            TRequest request,
            TResponse response,
            CancellationToken cancellationToken)
            => LogBehaviorForRequest(BehaviorNames.EndRequest);
    }
}
