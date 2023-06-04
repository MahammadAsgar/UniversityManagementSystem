using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversityManagement.Core.Entities.User;

namespace UniversityManagement.Data.Context.Configuration
{
    public class UserDegreeConfiguration : IEntityTypeConfiguration<UserDegree>
    {
        public void Configure(EntityTypeBuilder<UserDegree> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
