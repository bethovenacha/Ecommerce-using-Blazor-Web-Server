using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amarket;
namespace ECOMMERCE.Services.Cart
{
    public interface Icart
    {
        Task<IEnumerable<Amarket.Cart>> retrieve();
        Task<IEnumerable<Amarket.Cart>> retrieveById(object id);
        Task<Amarket.Cart> create(Amarket.Cart cart);
        Task<Amarket.Cart> update(Amarket.Cart cart);
        Task delete(object entity);
    }
}
