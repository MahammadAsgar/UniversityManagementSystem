using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversityManagement.Core.Entities.Main;

namespace UniversityManagement.Data.Context.Configuration
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Students);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(10);
        }
    }
}
