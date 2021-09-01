
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ecommerceRestApi.UnitOfWork
{
    public class UnitOfWork<TEntity> where TEntity : class
    {
        private Repository<TEntity> _repository;
        private DbContext context;

        public UnitOfWork(DbContext context)
        {
            this.context = context;
        }

        public Repository<TEntity> repository
        {
            get
            {
                _repository = new Repository<TEntity>(this.context);
                return _repository;
            }
        }
    }
}