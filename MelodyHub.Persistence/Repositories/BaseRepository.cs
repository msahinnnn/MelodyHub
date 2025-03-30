using MelodyHub.Application.Repositories;
using MelodyHub.Domain.Entitites.Cammon;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly DbContext _context;
        private readonly DbSet<BaseEntity> _dbSet;

        public BaseRepository(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = _context.Set<BaseEntity>();
        }

        public async Task<BaseEntity> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<BaseEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<IEnumerable<BaseEntity>> FindAsync(
            Expression<Func<BaseEntity, bool>> predicate,
            Func<IQueryable<BaseEntity>, IOrderedQueryable<BaseEntity>> orderBy = null,
            int? skip = null,
            int? take = null)
        {
            IQueryable<BaseEntity> query = _dbSet.Where(predicate);

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (skip.HasValue)
            {
                query = query.Skip(skip.Value);
            }

            if (take.HasValue)
            {
                query = query.Take(take.Value);
            }

            return await query.ToListAsync();
        }

        public async Task AddAsync(BaseEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(BaseEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null) throw new InvalidOperationException($"Entity with ID: {id} not found.");
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
