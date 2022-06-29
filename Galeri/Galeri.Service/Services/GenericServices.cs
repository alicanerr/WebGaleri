using Galeri.Core.Repository;
using Galeri.Core.Services;
using Galeri.Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Service.Services
{
    public class GenericServices<T> : IGenericService<T> where T :class
    {
        private readonly IGenericRepository<T> _repository;
        private readonly IGenericUnitOfWork _unitofWork;

        public GenericServices(IGenericRepository<T> repository, IGenericUnitOfWork unitofWork)
        {
            _repository = repository;
            _unitofWork = unitofWork;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await _unitofWork.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }

        public async Task RemoveAsync(T entity)
        {
            _repository.Remove(entity);
            await _unitofWork.CommitAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _repository.Update(entity);
            await _unitofWork.CommitAsync();
        }
    }
}
