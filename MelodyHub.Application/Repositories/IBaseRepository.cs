using MelodyHub.Domain.Entitites.Cammon;
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
        Task<IEnumerable<BaseEntity>> FindAsync(
            Expression<Func<BaseEntity, bool>> predicate,
            Func<IQueryable<BaseEntity>, IOrderedQueryable<BaseEntity>> orderBy = null,
            int? skip = null,
            int? take = null);
        Task AddAsync(BaseEntity entity);
        Task UpdateAsync(BaseEntity entity);
        Task DeleteAsync(int id);
    }
}
