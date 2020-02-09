using Kf.CANetCore31.Core.Domain.People;
using Kf.CANetCore31.DomainDrivenDesign;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;

namespace Kf.CANetCore31.Infrastructure.Persistence.Ef
{
    public static class ApplicationDbContextSeedConfiguration
    {
        public static void ConfigureSeed(
            this ModelBuilder modelBuilder)
        {
            modelBuilder.DataFor(
                Person.Create(1),
                Person.Create(33311)
            );
        }

        private static DataBuilder<TEntity> DataFor<TEntity>(
            this ModelBuilder modelBuilder,
            params TEntity[] entities)
            where TEntity : Entity
            => modelBuilder.DataFor(entities.ToList());

        private static DataBuilder<TEntity> DataFor<TEntity>(
            this ModelBuilder modelBuilder,
            IEnumerable<TEntity> entities)
            where TEntity : Entity
            => modelBuilder.Entity<TEntity>()
                .HasData(entities.IfNullThenEmpty());
    }
}
