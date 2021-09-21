using ECOMMERCE.Services.Cart;
using ECOMMERCE.Services.ProductService;
using ECOMMERCE.States;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECOMMERCE.Components.Product
{
    public class ProductViewBase : ComponentBase
    {
        [Inject]
        public Iproduct iProduct { get; set; }
        [Inject]
        public Icart ICart { get; set; }
        [Inject]
        public ProtectedLocalStorage ProtectedLocalStore { get; set; }
    
        [Parameter]
        public string Id { get; set; }//product id from the query string
        public List<Amarket.Product> product { get; set; } = new List<Amarket.Product>();

        [Inject]
        public NavigationManager NavManager { get; set; }

        public string viewCartStyle { get; set; } = "display:none;";

        protected override async Task OnInitializedAsync()
        {      
            product = (List<Amarket.Product>)await iProduct.retrieveById(Guid.Parse(Id));
        }
        protected async Task<Amarket.Cart> createCart()
        {
            var result = await ProtectedLocalStore.GetAsync<Guid>("CartId");
            Amarket.Cart cart = null;
            if (result.Success) {
                cart = new Amarket.Cart()
                {
                    Id = Guid.NewGuid(),
                    CartId = result.Value,
                    Tax = 0,
                    ShipmentFee = 0,
                    Price = product[0].Price,
                    Total = product[0].Price,
                    ProductId = product[0].Id,
                    Quantity = 1
                };
                viewCartStyle = "display:inline;";
            }
            return await ICart.create(cart);
        }

        protected void ViewCart() {
            NavManager.NavigateTo($"cart");

        }

    }
}
