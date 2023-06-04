using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Core.DTOs.Main.Get;
using UniversityManagement.Core.DTOs.Main.Post;
using UniversityManagement.Core.Entities.Main;

namespace UniversityManagement.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Department, PostDepartmentDto>().ReverseMap();
            CreateMap<Department, GetDepartmentDto>().ReverseMap();

            CreateMap<EducationDegree, PostEducationDegreeDto>().ReverseMap();
            CreateMap<EducationDegree, GetEducationDegreeDto>().ReverseMap();

            CreateMap<EducationLanguage, PostEducationLanguageDto>().ReverseMap();
            CreateMap<EducationLanguage, GetEducationLanguageDto>().ReverseMap();

            CreateMap<Faculity, PostFaculityDto>().ReverseMap();
            CreateMap<Faculity, GetFaculityDto>().ReverseMap();

            CreateMap<Speciality, PostSpecialityDto>().ReverseMap();
            CreateMap<Speciality, GetSpecialityDto>().ReverseMap();
        }
    }
}
