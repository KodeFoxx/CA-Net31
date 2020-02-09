using System.Threading;
using System.Threading.Tasks;

namespace Kf.CANetCore31.Core.Application
{
    public interface IWriteOnlyApplicationDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
