using ECOMMERCE.Services.Cart;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECOMMERCE.States;


namespace ECOMMERCE.Components.Cart
{
    public class CartViewBase: ComponentBase, IDisposable
    {
        [Inject]
        public NavigationManager NavManager { get; set; }
        [Inject]
        public IJSRuntime js { get; set; }
        [Inject]
        public Icart  ICart { get; set; }
        [Inject]
        public ProtectedLocalStorage localStorage { get; set; }

        [Parameter]
        public string id { get; set; } = string.Empty;//cart id from the query string

        public ElementReference ReferedCart;

        [CascadingParameter]
        public static CascadingAppStateProvider State { get; set; } = new CascadingAppStateProvider();

        protected override async Task OnInitializedAsync()
        {
            State.cartState.StateChanged += async (Source, property) => await CartState_StateChanged(Source, property);
            var cartId =  await localStorage.GetAsync<Guid>("CartId");

            if (id == string.Empty){     
                if (cartId.Success) {
                    id = (cartId.Value).ToString();
                    State.cartState.Cart = (List<Amarket.Cart>)await ICart.retrieveById(cartId.Value);
                }                
            }
            else {
                State.cartState.Cart = (List<Amarket.Cart>)await ICart.retrieveById(Guid.Parse(id));
            }
            
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (!firstRender) {
                var cartId = await localStorage.GetAsync<Guid>("CartId");
                if (cartId.Success)
                {
                    try
                    {
                        State.cartState.Cart = (List<Amarket.Cart>)await ICart.retrieveById(cartId.Value);
                    }
                    catch (Exception ex) {
                        State.cartState.Cart = new List<Amarket.Cart>();
                        NavManager.NavigateTo($"cart");
                    }
                    
                }
            }            
        }



        private async Task CartState_StateChanged(ComponentBase source, object property)
        {
            if (source != this)
            {
                await InvokeAsync(StateHasChanged);
            }
            await State.SaveChangesAsync();
        }

        public async Task returnId() {
           
            try
            {
                var cid = await js.InvokeAsync<string>("getId", ReferedCart);
                await ICart.delete(cid);
                State.cartState.Cart = (List<Amarket.Cart>)await ICart.retrieveById(Guid.Parse(id));
                NavManager.NavigateTo($"cart");
            }
            catch (Exception)
            {
                State.cartState.Cart = new List<Amarket.Cart>();
                NavManager.NavigateTo($"cart");
            }
           
        }

        public void Dispose()
        {
            State.cartState.StateChanged -= async (Source, property) => await CartState_StateChanged(Source, property);
        }
    }
}
