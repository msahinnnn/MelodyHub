using MelodyHub.Domain.Entitites.Cammon;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<BaseEntity> GetByIdAsync(int id);
        Task<IEnumerable<BaseEntity>> GetAllAsync();

        Task<IEnumerable<TResult>> GetAsync<TResult>(
         Expression<Func<BaseEntity, bool>> predicate,
         Func<IQueryable<BaseEntity>, IOrderedQueryable<BaseEntity>> orderBy = null,
         int? skip = null,
         int? take = null,
         Expression<Func<BaseEntity, TResult>> select = null,
         params Func<IQueryable<BaseEntity>, IIncludableQueryable<BaseEntity, object>>[] includes);


        Task<BaseEntity> FirstAsync(
        Expression<Func<BaseEntity, bool>> predicate,
        Func<IQueryable<BaseEntity>, IOrderedQueryable<BaseEntity>> orderBy = null,
        params Func<IQueryable<BaseEntity>, IIncludableQueryable<BaseEntity, object>>[] includes);


        Task<BaseEntity> AddAsync(BaseEntity entity);
        Task<BaseEntity> UpdateAsync(BaseEntity entity);
        Task<BaseEntity> DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}
