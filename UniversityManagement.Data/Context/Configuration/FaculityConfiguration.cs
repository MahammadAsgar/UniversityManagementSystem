using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversityManagement.Core.Entities.Main;

namespace UniversityManagement.Data.Context.Configuration
{
    public class FaculityConfiguration : IEntityTypeConfiguration<Faculity>
    {
        public void Configure(EntityTypeBuilder<Faculity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Specialities);
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
