using HMS.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Interfaces.Repositories.Base
{
    public interface IRepositoryBase<TEntity>
    {
        public Task<List<TEntity>> GetAsync();
        public Task<TEntity> GetByIdAsync(int ID);
        public Task<TEntity> CreateAsync(TEntity entity);
        public Task<TEntity> UpdateAsync(TEntity entity);
        public Task<int> DeleteAsync(TEntity entity);
    }
}
