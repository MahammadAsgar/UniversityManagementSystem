using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversityManagement.Core.Entities.Main;

namespace UniversityManagement.Data.Context.Configuration
{
    public class EducationDegreeConfiguration : IEntityTypeConfiguration<EducationDegree>
    {
        public void Configure(EntityTypeBuilder<EducationDegree> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
