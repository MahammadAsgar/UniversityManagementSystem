using SharedLibrary;
using System.Linq.Expressions;
using UniversityManagement.Core.Entities.Main;

namespace UniversityManagement.Core.Services
{
    public interface IGenericService<TEntity, TDto> where TEntity : BaseEntity where TDto : class
    {
        Task<Response<TDto>> GetByIdAsync(int id);
        Task<Response<IEnumerable<TDto>>> GetAllAsync();
        Task<Response<IEnumerable<TDto>>> Where(Expression<Func<TEntity, bool>> predicate);
        Task<Response<TDto>> AddAsync(TDto dto);
        Task<Response<NoDataDto>> Remove(int id);
        Task<Response<NoDataDto>> Update(TDto dto, int id);
    }
}
