using Kf.CANetCore31.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Kf.CANetCore31.Core.Application
{
    public interface IReadOnlyApplicationDbContext
    {
        DbSet<Person> People { get; set; }
    }
}
