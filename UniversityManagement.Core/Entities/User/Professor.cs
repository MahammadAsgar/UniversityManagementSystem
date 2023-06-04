namespace UniversityManagement.Core.Entities.User
{
    public class Professor : AppUser
    {
        public UserProfession UserProfession { get; set; }
        public UserDegree UserDegree { get; set; }
    }
}
