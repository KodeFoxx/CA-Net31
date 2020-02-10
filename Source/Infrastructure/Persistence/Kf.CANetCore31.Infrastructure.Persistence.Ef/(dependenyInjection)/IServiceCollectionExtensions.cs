using Kf.CANetCore31.Core.Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Kf.CANetCore31.Infrastructure.Persistence.Ef
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddAndConfigureSqlServerPersistence(
            this IServiceCollection serviceCollection,
            IConfiguration configuration)
            => serviceCollection
                .AddAndConfigureSqlServerDbContext<ApplicationDbContext>(
                    connectionString: configuration.GetConnectionString(nameof(ApplicationDbContext))
                )
                .AddDbContextScoped<IReadOnlyApplicationDbContext, ApplicationDbContext>()
                .AddDbContextScoped<IWriteOnlyApplicationDbContext, ApplicationDbContext>()
                .AddDbContextScoped<IReadWriteApplicationDbContext, ApplicationDbContext>();

        private static IServiceCollection AddAndConfigureSqlServerDbContext<TConcreteDbContext>(
            this IServiceCollection serviceCollection,
            string connectionString)
            where TConcreteDbContext : DbContext
            => serviceCollection
                .AddDbContext<TConcreteDbContext>(options =>
                    options.UseSqlServer(
                        connectionString: connectionString,
                        sqlServerOptionsAction: sqlOptions =>
                        {
                            sqlOptions.MigrationsAssembly(typeof(TConcreteDbContext).Assembly.FullName);
                        })
                );

        private static IServiceCollection AddDbContextScoped<TDbContext, TConcreteDbContext>(
            this IServiceCollection serviceCollection)
            where TConcreteDbContext : DbContext, TDbContext
            where TDbContext : class
            => serviceCollection.AddScoped<TDbContext>(
                implementationFactory: provider => provider.GetService<TConcreteDbContext>());
    }
}
