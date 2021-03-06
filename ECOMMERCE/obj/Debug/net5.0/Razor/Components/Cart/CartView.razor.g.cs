#pragma checksum "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\Components\Cart\CartView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "677641416c2dcbd874254f1df27730909a749bac"
// <auto-generated/>
#pragma warning disable 1591
namespace ECOMMERCE.Components.Cart
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/cart")]
    public partial class CartView : CartViewBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\"><div class=\"col-12\"><h5 class=\"float-start\">Cart</h5></div></div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-lg-4");
#nullable restore
#line 15 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\Components\Cart\CartView.razor"
         if (Cart == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<div class=\"spinner-border text-danger\" role=\"status\"><span class=\"visually-hidden\">Loading...</span></div>");
#nullable restore
#line 20 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\Components\Cart\CartView.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table-bordered table-responsive text-small");
            __builder.AddMarkupContent(8, @"<thead class=""bg-success text-small text-white""><tr><th>Product Name</th>
                        <th>Price</th>
                        <th>Shipment Fee</th>
                        <th>Tax</th>
                        <th>Quantity</th>
                        <th colspan=""2"">Action</th></tr></thead>");
#nullable restore
#line 34 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\Components\Cart\CartView.razor"
                 foreach (var c in Cart)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tbody");
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 38 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\Components\Cart\CartView.razor"
                                  c.Products.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                            ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 39 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\Components\Cart\CartView.razor"
                                  c.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                            ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 40 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\Components\Cart\CartView.razor"
                                  c.ShipmentFee

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                            ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 41 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\Components\Cart\CartView.razor"
                                  c.Tax

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "td");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "number");
            __builder.AddAttribute(26, "value", 
#nullable restore
#line 43 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\Components\Cart\CartView.razor"
                                                             c.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "min", "1");
            __builder.AddAttribute(28, "max", "100");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.OpenElement(30, "td");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "type", "button");
            __builder.AddAttribute(33, "class", "btn btn-outline-danger btn-sm carts");
            __builder.AddAttribute(34, "id", 
#nullable restore
#line 47 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\Components\Cart\CartView.razor"
                                                                                                       c.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\Components\Cart\CartView.razor"
                                                                                                                                          deleteCart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(36, (__value) => {
#nullable restore
#line 47 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\Components\Cart\CartView.razor"
                                                                                                                   ReferedCart = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(37, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                            ");
            __builder.AddMarkupContent(39, "<td><button class=\"btn btn-success btn-sm\">Update</button></td>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\Components\Cart\CartView.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\Components\Cart\CartView.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.AddMarkupContent(41, @"<div class=""col-lg-4""><form class=""form-control bg-light""><label class=""form-label"" for=""firstName"">First Name: </label>
            <input class=""form-control"" id=""firstName"">
            <label class=""form-label"" for=""mi"">Middle Initial: </label>
            <input class=""form-control"" id=""mi"">
            <label class=""form-label"" for=""lastname"">Last Name: </label>
            <input class=""form-control"" id=""lastname"">
            <label class=""form-label"" for=""address"">Address</label>
            <input type=""text"" class=""form-control"" id=""address""><br>
            <label class=""form-label"" for=""contact"">Contact Number:</label>
            <input class=""form-control"" max=""13"" min=""0"" id=""contact""><br>
            <label class=""form-label"" for=""notes"">Notes: </label><br>
            <input type=""text"" id=""notes""></form></div>
    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-lg-4");
            __builder.AddMarkupContent(44, @"<div class=""form-check""><input class=""form-check-input"" type=""radio"" name=""flexRadioDefault"" id=""flexRadioDefault1"" checked>
            <label class=""form-check-label"" for=""flexRadioDefault1"">
                Cash on Delivery
            </label></div>
        ");
            __builder.AddMarkupContent(45, "<div class=\"form-check\"><input class=\"form-check-input\" type=\"radio\" name=\"flexRadioDefault\" id=\"flexRadioDefault2\">\r\n            <label class=\"form-check-label\" for=\"flexRadioDefault2\">\r\n                Paypal\r\n            </label></div>\r\n        ");
            __builder.AddMarkupContent(46, "<div class=\"form-check\"><input class=\"form-check-input\" type=\"radio\" name=\"flexRadioDefault\" id=\"flexRadioDefault3\">\r\n            <label class=\"form-check-label\" for=\"flexRadioDefault3\">\r\n                Bank Transfer\r\n            </label></div>\r\n        ");
            __builder.AddMarkupContent(47, "<div class=\"form-check\"><input class=\"form-check-input\" type=\"radio\" name=\"flexRadioDefault\" id=\"flexRadioDefault4\">\r\n            <label class=\"form-check-label\" for=\"flexRadioDefault4\">\r\n                Issue Check\r\n            </label></div>\r\n\r\n        ");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "class", "btn-success btn-lg");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 102 "C:\Users\Ivy Acha\Desktop\localCopy\ECOMMERCE\Components\Cart\CartView.razor"
                                                     backToShop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, "Back to Shop");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.AddMarkupContent(53, "<button class=\"btn-danger btn-lg\">Checkout</button>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
