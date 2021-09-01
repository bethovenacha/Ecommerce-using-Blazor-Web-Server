using ECOMMERCE.Services.ProductService;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECOMMERCE.Components.Product
{
    public class ProductListBase : ComponentBase
    {
        public List<Amarket.Product> Products { get; set; } = new List<Amarket.Product>();
        [Inject]
        public Iproduct Iproduct { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Products = (List<Amarket.Product>)await Iproduct.retrieve();

        }


    }
}
