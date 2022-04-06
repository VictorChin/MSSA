#pragma checksum "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e42fd29a7ef32f1f377fac68efb6b27bd12aa893"
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
#line 1 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\_Imports.razor"
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
#line 6 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
__builder.AddContent(7, Pizza.Special.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n            ");
#nullable restore
#line 7 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
__builder.AddContent(9, Pizza.Special.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n        ");
            __builder.OpenElement(11, "form");
            __builder.AddAttribute(12, "class", "dialog-body");
            __builder.OpenElement(13, "div");
            __builder.AddMarkupContent(14, "<label>Size:</label>\r\n                ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "range");
            __builder.AddAttribute(17, "min", 
#nullable restore
#line 13 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                          Pizza.MinimumSize

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "max", 
#nullable restore
#line 13 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                   Pizza.MaximumSize

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "step", "1");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
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
#line 17 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
__builder.AddContent(25, Pizza.Size);

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "\" ($");
#nullable restore
#line 17 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
__builder.AddContent(27, Pizza.GetFormattedTotalPrice());

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, ")\r\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "id", "extraTopping");
            __builder.AddMarkupContent(32, "<label>Extra Toppings:</label>");
#nullable restore
#line 23 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                 if (toppings == null)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "select");
            __builder.AddAttribute(34, "class", "custom-select");
            __builder.AddAttribute(35, "disabled");
            __builder.OpenElement(36, "option");
            __builder.AddContent(37, "(loading...)");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                }
                else if (Pizza.Toppings.Count >= 6)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, "<div>(maximum reached)</div>");
#nullable restore
#line 32 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "select");
            __builder.AddAttribute(40, "class", "custom-select");
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 35 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                             ToppingSelected

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "value", "-1");
            __builder.AddAttribute(44, "disabled");
            __builder.AddAttribute(45, "selected");
            __builder.AddContent(46, "(select)");
            __builder.CloseElement();
#nullable restore
#line 37 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                         for (var i = 0; i < toppings.Count; i++)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(47, "option");
            __builder.AddAttribute(48, "value", 
#nullable restore
#line 39 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                            i

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 39 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
__builder.AddContent(49, toppings[i].Name);

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, " - ($");
#nullable restore
#line 39 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
__builder.AddContent(51, toppings[i].GetFormattedPrice());

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, ")");
            __builder.CloseElement();
#nullable restore
#line 40 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 42 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n            ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "toppings");
#nullable restore
#line 46 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                 foreach (var topping in Pizza.Toppings)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "topping");
#nullable restore
#line 49 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
__builder.AddContent(58, topping.Topping.Name);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.OpenElement(60, "span");
            __builder.AddAttribute(61, "class", "topping-price");
#nullable restore
#line 50 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
__builder.AddContent(62, topping.Topping.GetFormattedPrice());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                        ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "type", "button");
            __builder.AddAttribute(66, "class", "delete-topping");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                                                 () => RemoveTopping(topping.Topping)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(68, "x");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\r\n\r\n        ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "dialog-buttons");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "class", "btn btn-danger mr-auto");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                             OnCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(75, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n            ");
            __builder.OpenElement(77, "span");
            __builder.AddAttribute(78, "class", "mr-center");
            __builder.AddMarkupContent(79, "\r\n                Price: ");
            __builder.OpenElement(80, "span");
            __builder.AddAttribute(81, "class", "price");
#nullable restore
#line 61 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
__builder.AddContent(82, Pizza.GetFormattedTotalPrice());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.OpenElement(84, "button");
            __builder.AddAttribute(85, "class", "btn btn-success ml-auto");
            __builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
                                                              OnConfirm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(87, "Order >");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\blazorWorkshop\blazor-workshop\save-points\00-get-started\BlazingPizza.Client\Shared\ConfigurePizzaDialog.razor"
       
    [Parameter] public Pizza Pizza { get; set; }
    [Parameter] public EventCallback OnCancel { get; set; }
    [Parameter] public EventCallback OnConfirm { get; set; }

    List<Topping> toppings;



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