// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class RedirectToLogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 2 "C:\VictorMSSA\MSSA\Week1\BlazingPizza\save-points\05-checkout-with-validation\BlazingPizza.Client\Shared\RedirectToLogin.razor"
       
    protected override void OnInitialized()
    {
        Navigation.NavigateTo($"authentication/login?returnUrl={Navigation.Uri}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
