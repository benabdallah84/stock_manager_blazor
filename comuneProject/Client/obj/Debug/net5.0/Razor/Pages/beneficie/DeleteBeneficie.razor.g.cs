#pragma checksum "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\beneficie\DeleteBeneficie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3f1e810884d8eb35d068bc27745b4eac8b6714e"
// <auto-generated/>
#pragma warning disable 1591
namespace comuneProject.Client.Pages.beneficie
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
#line 2 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\beneficie\DeleteBeneficie.razor"
using comuneProject.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/beneficie/delete/{beneficieId:guid}")]
    public partial class DeleteBeneficie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Supprimé un bénéficie</h2>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.AddMarkupContent(3, "<h4>Do you want to delete this beneficie?</h4>\r\n    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.OpenElement(6, "tbody");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "<td>Nom de beneficie</td>\r\n                ");
            __builder.OpenElement(9, "td");
#nullable restore
#line 13 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\beneficie\DeleteBeneficie.razor"
__builder.AddContent(10, beneficie.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "<td>Occupation</td>\r\n                ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 17 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\beneficie\DeleteBeneficie.razor"
__builder.AddContent(15, beneficie.Post);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-group");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "submit");
            __builder.AddAttribute(21, "value", "Supprimé");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\beneficie\DeleteBeneficie.razor"
                                                    (async () => await Removebeneficie(beneficie.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "class", "btn btn-danger");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "submit");
            __builder.AddAttribute(27, "value", "Annulé");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\beneficie\DeleteBeneficie.razor"
                                                  (() => Cancel())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "class", "btn btn-warning");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\beneficie\DeleteBeneficie.razor"
       
    [Parameter]
    public Guid beneficieId { get; set; }

    beneficie beneficie = new beneficie();
    protected override async Task OnInitializedAsync()
    {
        beneficie = await Http.GetFromJsonAsync<beneficie>("/api/beneficies/" + beneficieId);
    }
    protected async Task Removebeneficie(Guid beneficieID)
    {
        await Http.DeleteAsync("api/beneficies/" + beneficieID);
        NavigationManager.NavigateTo("/beneficie/details");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("/beneficie/details");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
