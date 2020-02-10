using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Kf.CANetCore31.Core.Application.Behaviors
{
    public abstract class LogRequestBehavior<TRequest>
    {
        protected readonly ILogger<TRequest> _logger;

        public LogRequestBehavior(ILogger<TRequest> logger)
            => _logger = logger;

        protected Task LogBehaviorForRequest(string behavior, string requestName)
            => Task.Run(()
                => _logger.LogTrace(
                        $"{{Behavior}} {requestName}",
                        behavior, requestName
                    )
            );
    }
}
