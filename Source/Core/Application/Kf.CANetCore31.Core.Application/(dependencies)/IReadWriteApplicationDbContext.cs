namespace Kf.CANetCore31.Core.Application
{
    public interface IReadWriteApplicationDbContext
        : IReadOnlyApplicationDbContext, IWriteOnlyApplicationDbContext
    { }
}
