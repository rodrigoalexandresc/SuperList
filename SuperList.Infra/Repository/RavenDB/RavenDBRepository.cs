using Raven.Client;
using SuperList.Domain.Infra;
using SuperList.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SuperList.Infra.Repository.RavenDB
{
    public abstract class RavenDBRepository<TEntity> : IRepository<TEntity>
    {
        IAsyncDocumentSession session;
        UnitOfWorkRavenDB unitOfWork;

        public RavenDBRepository(IUnitOfWorkRavenDB unitOfWork)
        {
            this.unitOfWork = (UnitOfWorkRavenDB)unitOfWork;
            session = this.unitOfWork.Session;
        }

        public virtual async Task<IList<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await session.Query<TEntity>().Where(expression).ToListAsync();
        }

        public virtual async Task<TEntity> FindAsync(Guid id)
        {
            return await session.LoadAsync<TEntity>(id);
        }

        public virtual async Task SaveAsync(TEntity entity)
        {
            await session.StoreAsync(entity);
        }
    }
}
