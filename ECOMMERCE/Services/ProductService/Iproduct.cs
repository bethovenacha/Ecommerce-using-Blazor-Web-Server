using Amarket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECOMMERCE.Services.ProductService
{
    public interface Iproduct
    {
        Task<IEnumerable<Product>> retrieve();
        Task<IEnumerable<Product>> retrieveById(object id);
        Task<Product> create(Product product);
        Task<Product> update(Product product);
        Task<Product> delete(object entity);
    }
}
