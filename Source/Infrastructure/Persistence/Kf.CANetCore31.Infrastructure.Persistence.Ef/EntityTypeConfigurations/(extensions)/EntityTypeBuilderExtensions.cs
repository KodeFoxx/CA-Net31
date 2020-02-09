using Kf.CANetCore31.DomainDrivenDesign;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kf.CANetCore31.Infrastructure.Persistence.Ef.EntityTypeConfigurations
{
    public static class EntityTypeBuilderExtensions
    {
        public static void ConfigureId<TEntity>(
            this EntityTypeBuilder<TEntity> entityTypeBuilder,
            string idColumenName = "id")
            where TEntity : Entity
            => entityTypeBuilder.HasKey(e => e.Id);
    }
}
