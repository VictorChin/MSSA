#pragma checksum "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e546038d6c5d51dbec562ebe661d409e08c17780"
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
    public partial class ConfigurePizzaDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dialog-container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "dialog");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "dialog-title");
            __builder.OpenElement(6, "h2");
#nullable restore
#line 6 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
__builder.AddContent(7, Pizza.Special.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n            ");
#nullable restore
#line 7 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
__builder.AddContent(9, Pizza.Special.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "form");
            __builder.AddAttribute(12, "class", "dialog-body");
            __builder.OpenElement(13, "div");
            __builder.AddMarkupContent(14, "<label>Size:</label>\r\n                ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "range");
            __builder.AddAttribute(17, "min", 
#nullable restore
#line 12 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                          Pizza.MinimumSize

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "max", 
#nullable restore
#line 12 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                   Pizza.MaximumSize

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "step", "1");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                                                      Pizza.Size

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Pizza.Size = __value, Pizza.Size));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "span");
            __builder.AddAttribute(24, "class", "size-label");
#nullable restore
#line 14 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
__builder.AddContent(25, Pizza.Size);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "\" (£");
#nullable restore
#line 14 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
__builder.AddContent(27, Pizza.GetFormattedTotalPrice());

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, ")\r\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddMarkupContent(31, "<label>Extra Toppings:</label>");
#nullable restore
#line 19 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                 if (toppings == null)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "select");
            __builder.AddAttribute(33, "class", "custom-select");
            __builder.AddAttribute(34, "disabled");
            __builder.OpenElement(35, "option");
            __builder.AddContent(36, "(loading...)");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                }
                else if (Pizza.Toppings.Count >= 6)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "<div>(maximum reached)</div>");
#nullable restore
#line 28 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "select");
            __builder.AddAttribute(39, "class", "custom-select");
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 31 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                             ToppingSelected

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(41, "option");
            __builder.AddAttribute(42, "value", "-1");
            __builder.AddAttribute(43, "disabled");
            __builder.AddAttribute(44, "selected");
            __builder.AddContent(45, "(select)");
            __builder.CloseElement();
#nullable restore
#line 33 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                         for (var i = 0; i < toppings.Count; i++)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "option");
            __builder.AddAttribute(47, "value", 
#nullable restore
#line 35 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                            i

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 35 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
__builder.AddContent(48, toppings[i].Name);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(49, " - (£");
#nullable restore
#line 35 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
__builder.AddContent(50, toppings[i].GetFormattedPrice());

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, ")");
            __builder.CloseElement();
#nullable restore
#line 36 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 38 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "toppings");
#nullable restore
#line 42 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                 foreach (var topping in Pizza.Toppings)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "topping");
#nullable restore
#line 45 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
__builder.AddContent(57, topping.Topping.Name);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.OpenElement(59, "span");
            __builder.AddAttribute(60, "class", "topping-price");
#nullable restore
#line 46 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
__builder.AddContent(61, topping.Topping.GetFormattedPrice());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "type", "button");
            __builder.AddAttribute(65, "class", "delete-topping");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                                 () => RemoveTopping(topping.Topping)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(67, "x");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n        ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "dialog-buttons");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "class", "btn btn-secondary mr-auto");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                OnCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(74, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.OpenElement(76, "span");
            __builder.AddAttribute(77, "class", "mr-center");
            __builder.AddMarkupContent(78, "\r\n                Price: ");
            __builder.OpenElement(79, "span");
            __builder.AddAttribute(80, "class", "price");
#nullable restore
#line 56 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
__builder.AddContent(81, Pizza.GetFormattedTotalPrice());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n            ");
            __builder.OpenElement(83, "button");
            __builder.AddAttribute(84, "class", "btn btn-success ml-auto");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                              OnConfirm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(86, "Order >");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\blazorWorkshop\blazor-workshop\save-points\03-show-order-status\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
       
    List<Topping> toppings;

    [Parameter] public Pizza Pizza { get; set; }
    [Parameter] public EventCallback OnCancel { get; set; }
    [Parameter] public EventCallback OnConfirm { get; set; }

    protected async override Task OnInitializedAsync()
    {
        toppings = await HttpClient.GetFromJsonAsync<List<Topping>>("toppings");
    }

    void ToppingSelected(ChangeEventArgs e)
    {
        if (int.TryParse((string)e.Value, out var index) && index >= 0)
        {
            AddTopping(toppings[index]);
        }
    }

    void AddTopping(Topping topping)
    {
        if (Pizza.Toppings.Find(pt => pt.Topping == topping) == null)
        {
            Pizza.Toppings.Add(new PizzaTopping() { Topping = topping });
        }
    }

    void RemoveTopping(Topping topping)
    {
        Pizza.Toppings.RemoveAll(pt => pt.Topping == topping);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591