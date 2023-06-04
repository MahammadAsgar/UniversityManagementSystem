using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Core.Entities.Main;

namespace UniversityManagement.Core.DTOs.Main.Post
{
    public class PostFaculityDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<int> SpecialityIds { get; set; }
    }
}
