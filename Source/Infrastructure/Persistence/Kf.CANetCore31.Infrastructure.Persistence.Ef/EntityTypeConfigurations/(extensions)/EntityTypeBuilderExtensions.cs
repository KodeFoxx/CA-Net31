using Kf.CANetCore31.DomainDrivenDesign;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kf.CANetCore31.Infrastructure.Persistence.Ef.EntityTypeConfigurations
{
    public static class EntityTypeBuilderExtensions
    {
        public static void ConfigureId<TEntity>(
            this EntityTypeBuilder<TEntity> entityTypeBuilder,
            string idColumenName = "Id")
            where TEntity : Entity
        {
            entityTypeBuilder.HasKey(e => e.Id);
            entityTypeBuilder.OwnsOne(
                e => e.Id,
                id => id.Property(p => p.Value).HasColumnName(idColumenName)
            );
        }
    }
}
