#pragma checksum "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea850a2e4f6bf8bbea4783469e713d87694b71d3"
// <auto-generated/>
#pragma warning disable 1591
namespace comuneProject.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\_Imports.razor"
using comuneProject.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\_Imports.razor"
using comuneProject.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\_Imports.razor"
using Havit.Blazor.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\_Imports.razor"
using Havit.Blazor.Components.Web.Bootstrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\_Imports.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\_Imports.razor"
using comuneProject.Client.Pages.services;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-cjz00laega");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-cjz00laega");
            __builder.OpenComponent<comuneProject.Client.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-cjz00laega");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-cjz00laega><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-cjz00laega>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4 container");
            __builder.AddAttribute(14, "b-cjz00laega");
            __builder.OpenComponent<Havit.Blazor.Components.Web.Bootstrap.HxMessenger>(15);
            __builder.AddAttribute(16, "Position", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Havit.Blazor.Components.Web.Bootstrap.ToastContainerPosition>(
#nullable restore
#line 14 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Shared\MainLayout.razor"
                                   ToastContainerPosition.TopStart

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n            ");
#nullable restore
#line 15 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Shared\MainLayout.razor"
__builder.AddContent(18, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591