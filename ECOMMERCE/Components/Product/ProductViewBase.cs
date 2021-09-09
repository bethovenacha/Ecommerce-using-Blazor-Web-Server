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
    public class ProductViewBase : ComponentBase, IDisposable
    {
        [Inject]
        public Iproduct iProduct { get; set; }
        [Inject]
        public Icart ICart { get; set; }
        [Inject]
        public ProtectedLocalStorage ProtectedLocalStore { get; set; }
        [Inject]
                
        [CascadingParameter]
        public static CascadingAppStateProvider State { get; set; } = new CascadingAppStateProvider();

        //public AppState cartState { get; set; }
        [Parameter]
        public string Id { get; set; }//product id from the query string
        public List<Amarket.Product> product { get; set; } = new List<Amarket.Product>();

        public Guid cartId { get; set; } = Guid.Empty;

        public string ViewCartStyle { get; set; } = "";

        [Inject]
        public NavigationManager NavManager { get; set; }
        protected override async Task OnInitializedAsync()
        {
            product = (List<Amarket.Product>)await iProduct.retrieveById(Guid.Parse(Id));            
            State.cartState.StateChanged += async (Source, property) => await CartState_StateChanged(Source, property);
            ViewCartStyle = "display:none;";
        }

        private async Task CartState_StateChanged(ComponentBase source, object property) {
            if (source != this) {
                await InvokeAsync(StateHasChanged);
            }
            await State.SaveChangesAsync();
        }
        protected async Task<Amarket.Cart> createCart()
        {
            var id = await ProtectedLocalStore.GetAsync<Guid>("CartId");
            cartId = id.Value;

                Amarket.Cart cart = new Amarket.Cart()
                {
                    Id = Guid.NewGuid(),
                    CartId = id.Value,
                    Tax = 0,
                    ShipmentFee = 0,
                    Price = product[0].Price,
                    Total = product[0].Price,
                    ProductId = product[0].Id,
                    Quantity = 1,
                    UserId = Guid.Parse("160c3fad-0479-4e35-9cd9-06427c4bc9e2")
                };

            ViewCartStyle = "display: inline-block;";

            return await ICart.create(cart);  
        }

        protected async Task ViewCart() {
            var id = await ProtectedLocalStore.GetAsync<Guid>("CartId");
            if (id.Success) {
                NavManager.NavigateTo($"cart/{id.Value}");
            }
            
        }

        public void Dispose()
        {
           
            State.cartState.StateChanged -= async (Source, property) => await CartState_StateChanged(Source, property);
        }



    }
}
