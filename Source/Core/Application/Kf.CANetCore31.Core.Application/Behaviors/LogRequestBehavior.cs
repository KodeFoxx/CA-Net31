using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Kf.CANetCore31.Core.Application.Behaviors
{
    public abstract class LogRequestBehavior<TRequest>
    {
        public LogRequestBehavior(ILogger<TRequest> logger)
            => _logger = logger;

        protected readonly ILogger<TRequest> _logger;
        protected readonly Type _requestType = typeof(TRequest);
        protected readonly string _requestName = typeof(TRequest).GetTypeName();

        protected Task LogBehaviorForRequest(
            string behavior,
            string requestName = null,
            string message = null)
            => LogBehaviorForRequest(
                    LogLevel.Trace,
                    behavior,
                    requestName,
                    message);

        protected Task LogBehaviorForRequest(
            LogLevel logLevel,
            string behavior,
            string requestName = null,
            string message = null)
        {
            if (message.IsNullOrWhiteSpace())
            {
                return Task.Run(()
                    => _logger.Log(
                            logLevel,
                            $"{{Behavior}} {requestName.IfNullOrWhiteSpaceThen(_requestName)}",
                            behavior,
                            requestName.IfNullOrWhiteSpaceThen(_requestName)
                        )
                );
            }
            else
            {
                return Task.Run(()
                    => _logger.Log(
                            logLevel,
                            $"{{Behavior}} {requestName.IfNullOrWhiteSpaceThen(_requestName)}. {@message}",
                            behavior,
                            message
                        )
                );
            }
        }
    }
}
