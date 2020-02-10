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

            builder.OwnsOne(
                e => e.Name,
                name =>
                {
                    name.Property(p => p.FirstName)
                        .HasColumnName("firstName")
                        .HasMaxLength(150)
                        .HasColumnType(SqlServerColumnTypes.String_NVARCHAR);
                    name.Property(p => p.LastName)
                        .HasColumnName("lastName")
                        .HasMaxLength(150)
                        .HasColumnType(SqlServerColumnTypes.String_NVARCHAR);
                }
            );

            builder.Ignore(e => e.Number);
        }
    }
}
