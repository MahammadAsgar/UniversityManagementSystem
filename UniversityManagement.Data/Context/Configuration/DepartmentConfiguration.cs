using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversityManagement.Core.Entities.Main;

namespace UniversityManagement.Data.Context.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Professors);
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
