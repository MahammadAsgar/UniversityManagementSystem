using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversityManagement.Core.Entities.Main;

namespace UniversityManagement.Data.Context.Configuration
{
    public class SpecialityConfiguration : IEntityTypeConfiguration<Speciality>
    {
        public void Configure(EntityTypeBuilder<Speciality> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(250);
            builder.Property(x => x.Time)
                .IsRequired()
                .HasMaxLength(12);
        }
    }
}
