using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Components;
using Amarket;

namespace ECOMMERCE.Services.ProductService
{
    public class ProductService : Iproduct
    {
        //Download Microsoft.AspNetCore.Blazor.HttpClient
        private readonly HttpClient httpClient;
        public ProductService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public Task<Product> create(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> delete(object entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> retrieve()
        {
            return await httpClient.GetJsonAsync<IEnumerable<Product>>("api/product");
        }

        public async Task<IEnumerable<Product>> retrieveById(object id)
        {
            return await httpClient.GetJsonAsync<IEnumerable<Product>>($"api/product/{id}");
        }

        public Task<Product> update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
