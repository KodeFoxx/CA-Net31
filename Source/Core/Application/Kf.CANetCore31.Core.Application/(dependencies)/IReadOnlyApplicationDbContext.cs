using Kf.CANetCore31.Core.Domain.People;
using Microsoft.EntityFrameworkCore;

namespace Kf.CANetCore31.Core.Application
{
    public interface IReadOnlyApplicationDbContext
    {
        DbSet<Person> People { get; set; }
    }
}
