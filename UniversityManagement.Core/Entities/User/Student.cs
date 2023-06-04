using UniversityManagement.Core.Entities.Main;

namespace UniversityManagement.Core.Entities.User
{
    public class Student : AppUser
    {
        public int Score { get; set; }
        public char ScoreCode { get; set; }
        public EducationDegree EducationDegree { get; set; }
    }
}
