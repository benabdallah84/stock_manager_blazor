// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace comuneProject.Client.Pages.produit
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
#line 2 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\produit\DeleteProduct.razor"
using comuneProject.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/produit/delete/{productId:guid}")]
    public partial class DeleteProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\produit\DeleteProduct.razor"
       
    [Parameter]
    public Guid productId { get; set; }

    product product = new product();
    protected override async Task OnInitializedAsync()
    {
        product = await Http.GetFromJsonAsync<product>("/api/products/" + productId);
    }
    protected async Task Removeproduct(Guid productID)
    { 
        await Http.DeleteAsync("api/products/" + productID);
        NavigationManager.NavigateTo("/produit/details");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("/produit/details");
    }
   

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
