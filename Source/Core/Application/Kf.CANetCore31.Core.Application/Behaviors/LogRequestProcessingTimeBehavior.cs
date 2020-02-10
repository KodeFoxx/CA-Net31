using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Kf.CANetCore31.Core.Application.Behaviors
{
    public sealed class LogRequestProcessingTimeBehavior<TRequest, TResponse>
        : LogRequestBehavior<TRequest>, IPipelineBehavior<TRequest, TResponse>
    {
        public LogRequestProcessingTimeBehavior(
            ILogger<TRequest> logger)
            : base(logger)
            => _stopwatch = new Stopwatch();

        private readonly Stopwatch _stopwatch;
        private readonly ILogger<TRequest> _logger;

        public async Task<TResponse> Handle(
            TRequest request,
            CancellationToken cancellationToken,
            RequestHandlerDelegate<TResponse> next)
        {
            _stopwatch.Start();
            var response = await next();
            _stopwatch.Stop();

            var elapsedMilliseconds = _stopwatch.ElapsedMilliseconds;
            var logMessage = $"The request took {elapsedMilliseconds}ms.";
            var logLevel = elapsedMilliseconds > 500
                ? LogLevel.Warning
                : LogLevel.Trace;

            await LogBehaviorForRequest(
                    logLevel: logLevel,
                    behavior: BehaviorNames.ProcessingTimeRequest,
                    message: logMessage);

            return response;
        }
    }
}
