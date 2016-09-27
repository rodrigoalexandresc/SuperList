using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SuperList.Domain.Repositories
{
    public interface IRepository<TEntity> 
    {
        Task SaveAsync(TEntity entity);

        Task<TEntity> FindAsync(Guid id);

        Task<IList<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> expression);
    }
}
