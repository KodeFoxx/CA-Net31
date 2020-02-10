using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Linq;

namespace Kf.CANetCore31.Core.Application
{
    public static class IQueryableExtensions
    {
        public static IQueryable<TDestination> ProjectTo<TDestination>(
            this IQueryable queryable,
            IMapper mapper)
            => queryable.ProjectTo<TDestination>(mapper.ConfigurationProvider);
    }
}
