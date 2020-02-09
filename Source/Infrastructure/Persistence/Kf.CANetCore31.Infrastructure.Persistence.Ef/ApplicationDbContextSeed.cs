using System.Threading.Tasks;

namespace Kf.CANetCore31.Infrastructure.Persistence.Ef
{
    public sealed class ApplicationDbContextSeed
    {
        public static Task SeedAsync()
         => Task.CompletedTask;
    }
}
