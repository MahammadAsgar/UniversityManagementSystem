using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UniversityManagement.Core.Entities.Main;
using UniversityManagement.Core.Entities.User;
using UniversityManagement.Data.Context.Configuration;

namespace UniversityManagement.Data.Context
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new DepartmentConfiguration());
            builder.ApplyConfiguration(new FaculityConfiguration());
            builder.ApplyConfiguration(new GroupConfiguration());
            builder.ApplyConfiguration(new SpecialityConfiguration());
            builder.ApplyConfiguration(new UserProfessionConfiguration());
            builder.ApplyConfiguration(new UserDegreeConfiguration());
            builder.ApplyConfiguration(new EducationDegreeConfiguration());
            base.OnModelCreating(builder);
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Faculity> Faculities { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<UserProfession> UserProfessions { get; set; }
        public DbSet<UserDegree> UserDegrees { get; set; }
        public DbSet<EducationDegree> EducationDegrees { get; set; }
        public DbSet<EducationLanguage> EducationLanguages { get; set; }
    }
}
