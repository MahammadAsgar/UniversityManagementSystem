using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversityManagement.Core.Entities.User;

namespace UniversityManagement.Data.Context.Configuration
{
    public class UserProfessionConfiguration : IEntityTypeConfiguration<UserProfession>
    {
        public void Configure(EntityTypeBuilder<UserProfession> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
