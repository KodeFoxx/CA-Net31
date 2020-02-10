using MediatR.Pipeline;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Kf.CANetCore31.Core.Application.Behaviors
{
    public sealed class LogRequestStartBehavior<TRequest>
        : LogRequestBehavior<TRequest>, IRequestPreProcessor<TRequest>
    {
        public LogRequestStartBehavior(ILogger<TRequest> logger)
            : base(logger)
        { }

        public Task Process(
            TRequest request,
            CancellationToken cancellationToken)
            => LogBehaviorForRequest(BehaviorNames.StartRequest);
    }
}
