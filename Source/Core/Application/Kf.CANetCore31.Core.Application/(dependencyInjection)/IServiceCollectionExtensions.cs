using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Kf.CANetCore31.Core.Application
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(
            this IServiceCollection serviceCollection,
            IConfiguration configuration = default)
        {
            return serviceCollection;
        }
    }
}
