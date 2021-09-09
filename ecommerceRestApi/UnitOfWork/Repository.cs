
using ecommerceRestApi.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;

using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace ecommerceRestApi.UnitOfWork
{
    public class Repository<TEntity> : IunitOfWork<TEntity> where TEntity : class
    {
        internal DbContext _context;
        internal DbSet<TEntity> dbset;

        public Repository(DbContext context)
        {
            _context = context;
            dbset = _context.Set<TEntity>();
        }

        public virtual async Task<TEntity> create(TEntity entity)
        {
            var result = await this.dbset.AddAsync(entity);
            await this._context.SaveChangesAsync();
            return result.Entity;
         
        }
        public virtual async Task<TEntity> delete(object id)
        {
            var result = await dbset.FindAsync(id);
            if (result != null)
            {
                _context.Entry(result).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
            }
            return result;
        }
        public virtual async Task<IEnumerable<TEntity>> retrieve(                
             Expression<Func<TEntity, bool  >> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = ""
            )
        {
            IQueryable<TEntity> query = this.dbset;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query =  query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }


        //public virtual async Task<TEntity> retrieveById(object id)
        //{
            
        //    return await dbset.FindAsync(id);
           
        //}
        public virtual async Task<TEntity> update(TEntity entity)
        {
           var result = this.dbset.Attach(entity);
            this._context.Entry(entity).State = EntityState.Modified;
           await this._context.SaveChangesAsync();
            return result.Entity;
        }
    
    }
}