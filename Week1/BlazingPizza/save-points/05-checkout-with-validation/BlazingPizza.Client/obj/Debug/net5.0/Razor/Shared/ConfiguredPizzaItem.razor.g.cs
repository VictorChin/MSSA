#pragma checksum "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96d31ede0bb917576ad410e060179c3b087aa104"
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
#line 1 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\_Imports.razor"
using BlazingComponents;

#line default
#line hidden
#nullable disable
    public partial class ConfiguredPizzaItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "cart-item");
            __builder.OpenElement(2, "a");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 2 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
                 OnRemoved

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "class", "delete-item");
            __builder.AddContent(5, "x");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "title");
#nullable restore
#line 3 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
__builder.AddContent(9, Pizza.Size);

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "\" ");
#nullable restore
#line 3 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
__builder.AddContent(11, Pizza.Special.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "ul");
#nullable restore
#line 5 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
         foreach (var topping in Pizza.Toppings)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "li");
            __builder.AddContent(15, "+ ");
#nullable restore
#line 7 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
__builder.AddContent(16, topping.Topping.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 8 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "item-price");
#nullable restore
#line 11 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
__builder.AddContent(20, Pizza.GetFormattedTotalPrice());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\Shared\ConfiguredPizzaItem.razor"
       
    [Parameter] public Pizza Pizza { get; set; }
    [Parameter] public EventCallback OnRemoved { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
