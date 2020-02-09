using Kf.CANetCore31.Core.Domain.People;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Kf.CANetCore31.Infrastructure.Persistence.Ef
{
    public sealed class ApplicationDbContextSeed
    {
        public static Task SeedAsync(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasData(new[]
                {
                    Person.Create(1),
                    Person.Create(33311)
                });

            return Task.CompletedTask;
        }
    }
}
