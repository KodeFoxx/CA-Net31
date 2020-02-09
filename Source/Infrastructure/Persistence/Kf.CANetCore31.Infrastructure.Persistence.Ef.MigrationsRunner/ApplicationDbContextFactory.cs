using Microsoft.EntityFrameworkCore.Design;

namespace Kf.CANetCore31.Infrastructure.Persistence.Ef.MigrationsRunner
{
    public sealed class ApplicationDbContextFactory
        : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
    }
}
