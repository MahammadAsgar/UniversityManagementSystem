using AutoMapper;
using SharedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Core.Entities.Main;
using UniversityManagement.Core.Repositories;
using UniversityManagement.Core.Services;
using UniversityManagement.Core.UnitOfWorks;

namespace UniversityManagement.Service.Services
{
    public class GenericService<TEntity, TDto> : IGenericService<TEntity, TDto> where TEntity : BaseEntity where TDto : class
    {
        readonly IMapper _mapper;
        readonly IUnitOfWork _unitOfWork;
        readonly IGenericRepository<TEntity> _genericRepository;
        public GenericService(IMapper mapper, IUnitOfWork unitOfWork, IGenericRepository<TEntity> genericRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _genericRepository = genericRepository;
        }
        public async Task<Response<TDto>> AddAsync(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _genericRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return Response<TDto>.Success(_mapper.Map<TDto>(entity));
        }

        public async Task<Response<IEnumerable<TDto>>> GetAllAsync()
        {
            var entities = await _genericRepository.GetAllAsync();
            if (entities != null)
            {
                var response = _mapper.Map<IEnumerable<TDto>>(entities);
                return Response<IEnumerable<TDto>>.Success(response);
            }
            return Response<IEnumerable<TDto>>.Fail("Data not found");
        }

        public async Task<Response<TDto>> GetByIdAsync(int id)
        {
            var entity = await _genericRepository.GetByIdAsync(id);
            if (entity != null)
            {
                var response = _mapper.Map<TDto>(entity);
                return Response<TDto>.Success(response);
            }
            return Response<TDto>.Fail("Data not found");
        }

        public async Task<Response<NoDataDto>> Remove(int id)
        {
            var entity = await _genericRepository.GetByIdAsync(id);
            if (entity!=null)
            {
                _genericRepository.Remove(entity);
                _unitOfWork.Commit();
                return Response<NoDataDto>.Success("Remove Successful");
            }
            return Response<NoDataDto>.Fail("No Data Found");
        }

        public Task<Response<NoDataDto>> Update(TDto dto, int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<IEnumerable<TDto>>> Where(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
