using Kf.CANetCore31.DomainDrivenDesign;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kf.CANetCore31.Infrastructure.Persistence.Ef.EntityTypeConfigurations
{
    public abstract class EntityTypeConfiguration<TEntity>
        : IEntityTypeConfiguration<TEntity>
        where TEntity : Entity
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.ConfigureId();
            WithIdConfiguredThen(builder);
        }

        public abstract void WithIdConfiguredThen(EntityTypeBuilder<TEntity> builder);
    }
}
