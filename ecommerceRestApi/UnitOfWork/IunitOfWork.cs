using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ecommerceRestApi.UnitOfWork
{
    public interface IunitOfWork<TEntity>  where TEntity: class
    {
        Task<IEnumerable<TEntity>> retrieve(
            Expression<Func<TEntity, bool >> expression,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> queryable,
            string includeProperties);
        //Task<TEntity> retrieveById(object id, string includeProperties);
        Task<TEntity> create(TEntity entity);
        Task<TEntity> update(TEntity entity);
        Task<TEntity> delete(object entity);
     
      
    }
}
