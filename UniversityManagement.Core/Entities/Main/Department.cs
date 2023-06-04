using UniversityManagement.Core.Entities.User;

namespace UniversityManagement.Core.Entities.Main
{
    public class Department : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Professor> Professors { get; set; }
    }
}
