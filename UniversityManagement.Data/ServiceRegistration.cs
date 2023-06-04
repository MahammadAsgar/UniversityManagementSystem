using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UniversityManagement.Core.Entities.User;
using UniversityManagement.Core.Repositories;
using UniversityManagement.Core.UnitOfWorks;
using UniversityManagement.Data.Context;
using UniversityManagement.Data.Repositories;
using UniversityManagement.Data.UnitOfWorks;

namespace UniversityManagement.Data
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(ConnectionConfiguration.ConnectionString));
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}
