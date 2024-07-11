// RepositoryBase.cs

using HMS.Domain.Entities;
using HMS.Domain.Interfaces.Repositories;
using HMS.Infrastructure.Contexts;

using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace HMS.Infrastructure.BaseRepository
{
    public abstract class RepositoryBase<TEntity> where TEntity : class
    {
        protected readonly Context _context;
        private readonly IUnitOfWork _unitOfWork;

        public RepositoryBase(Context context, IUnitOfWork unitOfWork)
        {
            _context = context ?? throw new Exception("ee");
            _unitOfWork = unitOfWork;
        }

        public virtual async Task<TEntity?> CreateAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            if (await _unitOfWork.ExecuteInTransactionAsync() == 1)
                return entity;
            else
                return default(TEntity);
        }

        public virtual async Task<int> DeleteAsync(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            int rowsAffected = await _unitOfWork.ExecuteInTransactionAsync();
            if (rowsAffected == 1)
                return rowsAffected;
            else
                return rowsAffected;
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(Int64 ID)
        {
            return await _context.Set<TEntity>().FindAsync(ID) ?? default;
        }


    }
}
