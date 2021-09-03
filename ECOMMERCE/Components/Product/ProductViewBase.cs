using ECOMMERCE.Services.Cart;
using ECOMMERCE.Services.ProductService;
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
        public CartState cartState { get; set; }
        [Parameter]
        public string Id { get; set; }//product id from the query string
        public List<Amarket.Product> product { get; set; } = new List<Amarket.Product>();

        public Guid _CartId { get; set; } = Guid.NewGuid();
        public string ViewCartButtonClass { get; set; }

        protected override async Task OnInitializedAsync()
        {
            product = (List<Amarket.Product>)await iProduct.retrieveById(Guid.Parse(Id));
            cartState.StateChanged += async (Source, property) => await CartState_StateChanged(Source, property);
            ViewCartButtonClass = "none;";
        }


        protected override async Task OnParametersSetAsync()
        {
            await ProtectedLocalStore.SetAsync("CartId", _CartId);

        }

        private async Task CartState_StateChanged(ComponentBase source, object property) {
            if (source != this) {
                await InvokeAsync(StateHasChanged);
            }
        }


        protected async Task<Amarket.Cart> createCart()
        {
            var id = await ProtectedLocalStore.GetAsync<Guid>("CartId");     
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

            ViewCartButtonClass = "inline-block";
            return await ICart.create(cart);
            
        }

        public void Dispose()
        {
            cartState.StateChanged += async (Source, property) => await CartState_StateChanged(Source, property);
        }

        //public event Action OnChange;
        //public void NotifyStateChanged() => OnChange?.Invoke();


    }
}
