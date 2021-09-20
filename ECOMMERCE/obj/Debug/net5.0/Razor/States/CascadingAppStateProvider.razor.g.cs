#pragma checksum "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\States\CascadingAppStateProvider.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa3ea69634a147101b32f4ba685f39d03eec5118"
// <auto-generated/>
#pragma warning disable 1591
namespace ECOMMERCE.States
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\_Imports.razor"
using ECOMMERCE.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\_Imports.razor"
using ECOMMERCE.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\_Imports.razor"
using ECOMMERCE.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\_Imports.razor"
using Amarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\_Imports.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\_Imports.razor"
using ECOMMERCE.States;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\_Imports.razor"
using ECOMMERCE.Shared;

#line default
#line hidden
#nullable disable
    public partial class CascadingAppStateProvider : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\States\CascadingAppStateProvider.razor"
 if (@hasLoaded)
{

#line default
#line hidden
#nullable disable
            __Blazor.ECOMMERCE.States.CascadingAppStateProvider.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 5 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\States\CascadingAppStateProvider.razor"
                            this

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
                __builder2.AddContent(3, 
#nullable restore
#line 6 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\States\CascadingAppStateProvider.razor"
         ChildContent

#line default
#line hidden
#nullable disable
                );
            }
            );
#nullable restore
#line 8 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\States\CascadingAppStateProvider.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\States\CascadingAppStateProvider.razor"
       
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    public CartState cartState { get; set; } = new CartState();
    bool hasLoaded;



    public async Task SaveChangesAsync()
    {
        await localStorage.SetAsync("CartId", cartState.CartId);
       
    }

    protected override Task OnInitializedAsync()
    {
        return SaveChangesAsync();
    }

    protected override async Task OnParametersSetAsync()
    {
        var result = await localStorage.GetAsync<Guid>("CartId");

        if (result.Success)
        {
            cartState.SetCartId(this, result.Value);

        }
        hasLoaded = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage localStorage { get; set; }
    }
}
namespace __Blazor.ECOMMERCE.States.CascadingAppStateProvider
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
