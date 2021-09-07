using ECOMMERCE.Services.Cart;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECOMMERCE.Components.Cart
{
    public class CartViewBase: ComponentBase
    {
       [Inject]
        public Icart  ICart { get; set; }
        [Inject]
        public ProtectedLocalStorage localStorage { get; set; }
        public List<Amarket.Cart> cart { get; set; } = new List<Amarket.Cart>();

        [Parameter]
        public string id { get; set; } = string.Empty;//product id from the query string
        protected override async Task OnInitializedAsync()
        {
            if (id == string.Empty)
            {
                var cartId = await localStorage.GetAsync<Guid>("CartId");
                if (cartId.Success) {
                    cart = (List<Amarket.Cart>)await ICart.retrieveById(cartId.Value);
                }                
            }
            else {
                cart = (List<Amarket.Cart>)await ICart.retrieveById(id);
               
                
            }
            
        }
    }
}
