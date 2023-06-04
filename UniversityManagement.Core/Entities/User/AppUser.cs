using Microsoft.AspNetCore.Identity;

namespace UniversityManagement.Core.Entities.User
{
    public class AppUser : IdentityUser<int>
    {
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Description { get; set; }
    }
}
