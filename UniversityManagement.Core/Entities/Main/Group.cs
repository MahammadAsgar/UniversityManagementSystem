using UniversityManagement.Core.Entities.User;

namespace UniversityManagement.Core.Entities.Main
{
    public class Group : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
