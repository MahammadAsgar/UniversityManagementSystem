using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary;
using UniversityManagement.Core.DTOs.Main.Get;
using UniversityManagement.Core.DTOs.Main.Post;
using UniversityManagement.Core.Entities.Main;
using UniversityManagement.Core.Services;

namespace UniversityManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        readonly IGenericService<Department, PostDepartmentDto> _genericService;
        public DepartmentController(IGenericService<Department, TDto> genericService)
        {
            _genericService = _genericService;
        }


        [HttpPost]
        public async Task<ActionResult<Response<TDto>> AddDepartment(PostDepartmentDto departmentDto){}

}
}
