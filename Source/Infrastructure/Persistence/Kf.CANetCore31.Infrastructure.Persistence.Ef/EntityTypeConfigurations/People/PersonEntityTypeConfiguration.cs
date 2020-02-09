using Kf.CANetCore31.Core.Domain.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kf.CANetCore31.Infrastructure.Persistence.Ef.EntityTypeConfigurations.People
{
    public sealed class PersonEntityTypeConfiguration
        : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ConfigureId();
            builder.Ignore(e => e.Id);
            builder.Ignore(e => e.Number);
        }
    }
}
