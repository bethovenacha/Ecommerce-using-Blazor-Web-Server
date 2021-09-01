using Amarket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace ECOMMERCE.Services.Cart
{
    public class CartService : Icart
    {

        private readonly HttpClient httpClient;

        public CartService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Amarket.Cart> create(Amarket.Cart cart)
        {
            return await httpClient.PostJsonAsync<Amarket.Cart>($"api/cart",cart);
        }

        public Task<Amarket.Cart> delete(object entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Amarket.Cart>> retrieve()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Amarket.Cart>> retrieveById(object id)
        {
            throw new NotImplementedException();
        }

        public Task<Amarket.Cart> update(Amarket.Cart cart)
        {
            throw new NotImplementedException();
        }
    }
}
