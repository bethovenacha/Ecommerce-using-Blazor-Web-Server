using Amarket;
using ECOMMERCE.Services.Cart;
using ECOMMERCE.States;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECOMMERCE.Shared
{
    public class NavMenuBase : ComponentBase, IDisposable
    {
        [Inject]
        [CascadingParameter]
        public CascadingAppStateProvider State { get; set; } = new CascadingAppStateProvider();
        [Inject]
        public ProtectedLocalStorage localStorage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            State.cartState.StateChanged += async (Source, property) => await CartState_StateChanged(Source, property);
            State.cartState = new CartState();
            var id = await localStorage.GetAsync<Guid>("CartId");
            if (id.Success)
            {
                State.cartState.SetCartId(this, id.Value);
            }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender == false) {
                var id = await localStorage.GetAsync<Guid>("CartId");
                if (id.Success)
                {
                    State.cartState.SetCartId(this, id.Value);
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

        public void Dispose()
        {
            State.cartState.StateChanged -= async (Source, property) => await CartState_StateChanged(Source, property);
        }
    }
}
