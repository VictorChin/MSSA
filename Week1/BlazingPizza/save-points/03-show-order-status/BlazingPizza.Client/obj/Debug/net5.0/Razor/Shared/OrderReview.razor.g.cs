#pragma checksum "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\OrderReview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e72ad15bda5aa9c03230e015762fa1d5d28aa5b6"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingPizza.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary;

#line default
#line hidden
#nullable disable
    public partial class OrderReview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\OrderReview.razor"
 foreach (var pizza in Order.Pizzas)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "p");
            __builder.OpenElement(1, "strong");
#nullable restore
#line 5 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\OrderReview.razor"
__builder.AddContent(2, pizza.Size);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "\"\r\n            ");
#nullable restore
#line 6 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\OrderReview.razor"
__builder.AddContent(4, pizza.Special.Name);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "\r\n            (£");
#nullable restore
#line 7 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\OrderReview.razor"
__builder.AddContent(6, pizza.GetFormattedTotalPrice());

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, ")\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(8, "ul");
#nullable restore
#line 12 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\OrderReview.razor"
         foreach (var topping in pizza.Toppings)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "li");
            __builder.AddContent(10, "+ ");
#nullable restore
#line 14 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\OrderReview.razor"
__builder.AddContent(11, topping.Topping.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 15 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\OrderReview.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 17 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\OrderReview.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "p");
            __builder.OpenElement(13, "strong");
            __builder.AddMarkupContent(14, "\r\n        Total price:\r\n        £");
#nullable restore
#line 22 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\OrderReview.razor"
__builder.AddContent(15, Order.GetFormattedTotalPrice());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\OrderReview.razor"
       
    [Parameter] public Order Order { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591