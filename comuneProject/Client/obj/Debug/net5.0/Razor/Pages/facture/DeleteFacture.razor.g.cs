#pragma checksum "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\DeleteFacture.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91cbe5d9f27b966efd14278652064710b5974b26"
// <auto-generated/>
#pragma warning disable 1591
namespace comuneProject.Client.Pages.facture
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
#nullable restore
#line 2 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\DeleteFacture.razor"
using comuneProject.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/facture/delete/{factureId:guid}")]
    public partial class DeleteFacture : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Supprimé un produit</h2>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.AddMarkupContent(3, "<h4>Do you want to delete this facture?</h4>\r\n    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.OpenElement(6, "tbody");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "<td>N° facture</td>\r\n                ");
            __builder.OpenElement(9, "td");
#nullable restore
#line 13 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\DeleteFacture.razor"
__builder.AddContent(10, facture.Num_facture);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "<td>Désignation</td>\r\n                ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 17 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\DeleteFacture.razor"
__builder.AddContent(15, facture.Designation);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "<td>Date de facture</td>\r\n                ");
            __builder.OpenElement(19, "td");
#nullable restore
#line 21 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\DeleteFacture.razor"
__builder.AddContent(20, facture.Date_facture);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-group");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "submit");
            __builder.AddAttribute(26, "value", "Supprimé");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\DeleteFacture.razor"
                                                    (async () => await Removefacture(facture.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "class", "btn btn-danger");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "submit");
            __builder.AddAttribute(32, "value", "Annulé");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\DeleteFacture.razor"
                                                  (() => Cancel())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "class", "btn btn-warning");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\DeleteFacture.razor"
       
    [Parameter]
    public Guid factureId { get; set; }

    facture facture = new facture();
    protected override async Task OnInitializedAsync()
    {
        facture = await Http.GetFromJsonAsync<facture>("/api/factures/" + factureId);
    }
    protected async Task Removefacture(Guid factureID)
    {
        await Http.DeleteAsync("api/factures/" + factureID);
        NavigationManager.NavigateTo("/facture/details");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("/facture/details");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
