using MelodyHub.Application.Repositories;
using MelodyHub.Domain.Entitites.Cammon;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
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

        public async Task<IEnumerable<TResult>> FindAsync<TResult>(
        Expression<Func<BaseEntity, bool>> predicate,
        Func<IQueryable<BaseEntity>, IOrderedQueryable<BaseEntity>> orderBy = null,
        int? skip = null,
        int? take = null,
        Expression<Func<BaseEntity, TResult>> select = null,
        params Func<IQueryable<BaseEntity>, IIncludableQueryable<BaseEntity, object>>[] includes)
        {
            IQueryable<BaseEntity> query = _dbSet;

            // Includes
            foreach (var include in includes)
            {
                query = include(query);
            }

            // Filtering
            query = query.Where(predicate);

            // Order
            if (orderBy != null)
            {
                query = orderBy(query);
            }

            // Paging
            if (skip.HasValue)
            {
                query = query.Skip(skip.Value);
            }
            if (take.HasValue)
            {
                query = query.Take(take.Value);
            }

            // Select
            if (select != null)
            {
                return await query.Select(select).ToListAsync();
            }
            else
            {
                return (await query.ToListAsync()).Cast<TResult>();
            }
        }


        public async Task<BaseEntity> FirstAsync(
        Expression<Func<BaseEntity, bool>> predicate,
        Func<IQueryable<BaseEntity>, IOrderedQueryable<BaseEntity>> orderBy = null,
        params Func<IQueryable<BaseEntity>, IIncludableQueryable<BaseEntity, object>>[] includes)
        {
            IQueryable<BaseEntity> query = _dbSet;

            foreach (var include in includes)
            {
                query = include(query);
            }

            query = query.Where(predicate);

            if (orderBy != null)
            {
                query = orderBy(query);
            }
            return await query.FirstOrDefaultAsync();
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
            if (!await ExistsAsync(id))
            {
                throw new InvalidOperationException($"Entity with ID: {id} not found.");
            }
            var entity = await _dbSet.FindAsync(id);
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _dbSet.AnyAsync(e => EF.Property<int>(e, "Id") == id);
        }
    }
}
