namespace UniversityManagement.Core.Entities.Main
{
    public class Faculity : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Speciality> Specialities { get; set; }
    }
}
