using ECOMMERCE.Services.Cart;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECOMMERCE.States;


namespace ECOMMERCE.Components.Cart
{
    public class CartViewBase : ComponentBase
    {
        [Inject]
        public NavigationManager NavManager { get; set; }
        [Inject]
        public IJSRuntime js { get; set; }
        [Inject]
        public Icart ICart { get; set; }
        [Inject]
        public ProtectedLocalStorage localStorage { get; set; }

        public ElementReference ReferedCart;

        public List<Amarket.Cart> Cart { get; set; } = new List<Amarket.Cart>();

        public Guid cartId { get; set; } = Guid.Empty;
        protected async Task SetCart()
        {
            var id = await localStorage.GetAsync<Guid>("CartId");
            if (id.Success)
            {
                Cart = (List<Amarket.Cart>)await ICart.retrieveById(id.Value.ToString());
            }
        }
        protected override async Task OnInitializedAsync()
        {
            await Task.Run(SetCart);           
        }

       
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender == false) {
                await Task.Run(SetCart);
            }  
        }

        public async Task deleteCart()
        {
            try
            {
                var cid = await js.InvokeAsync<string>("getId", ReferedCart);

                await ICart.delete(cid);

                await Task.Run(SetCart);
                NavManager.NavigateTo("cart");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
             
            }
            
        }

    }
}
