#pragma checksum "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\Components\Product\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "005b915c94f817b07feeacfa681d1cd74c46f531"
// <auto-generated/>
#pragma warning disable 1591
namespace ECOMMERCE.Components.Product
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\_Imports.razor"
using ECOMMERCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\_Imports.razor"
using ECOMMERCE.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\_Imports.razor"
using Amarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\_Imports.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productList")]
    public partial class ProductList : ProductListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\Components\Product\ProductList.razor"
 foreach (var product in Products)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-4");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
#nullable restore
#line 8 "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\Components\Product\ProductList.razor"
              
                var image = product.Image.FirstOrDefault(i => i.ImageStatus == "Primary" && i.ProductId == product.Id);
            

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "src", "ProductImage/" + (
#nullable restore
#line 11 "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\Components\Product\ProductList.razor"
                                    image.ProductImagePath

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "class", "card-img-top");
            __builder.AddAttribute(7, "alt", "ProductImage");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.OpenElement(11, "h5");
            __builder.AddAttribute(12, "class", "card-title");
            __builder.AddContent(13, 
#nullable restore
#line 14 "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\Components\Product\ProductList.razor"
                                        product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "p");
            __builder.AddAttribute(16, "class", "card-text");
            __builder.AddContent(17, 
#nullable restore
#line 15 "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\Components\Product\ProductList.razor"
                                      product.ShortDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", 
#nullable restore
#line 16 "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\Components\Product\ProductList.razor"
                           $"product/{product.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddContent(22, "View");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Ivy Acha\Desktop\digoy\PORTFOLIO\ECOMMERCE\ECOMMERCE\ECOMMERCE\Components\Product\ProductList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
