using Kf.CANetCore31.Core.Domain.People;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kf.CANetCore31.Infrastructure.Persistence.Ef.EntityTypeConfigurations.People
{
    public sealed class PersonEntityTypeConfiguration
        : EntityTypeConfiguration<Person>
    {
        public override void WithIdConfiguredThen(EntityTypeBuilder<Person> builder)
        {
            builder.Ignore(e => e.Number);
        }
    }
}
