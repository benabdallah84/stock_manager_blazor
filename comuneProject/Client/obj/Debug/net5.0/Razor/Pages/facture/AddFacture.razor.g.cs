#pragma checksum "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\AddFacture.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba68547e7ce7caa5ff0c88b476bfaa16be06c2da"
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
#line 3 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\AddFacture.razor"
using comuneProject.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/facture/edit/{factureId:guid}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/facture/add")]
    public partial class AddFacture : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Ajouté Facture</h1>\r\n<hr>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\AddFacture.razor"
                  facture

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\AddFacture.razor"
                                          Savefacture

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "mb-3");
                __builder2.AddMarkupContent(9, "<label for=\"Num_facture\" class=\"form-label\">N° de facture</label>\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-md-4");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\AddFacture.razor"
                                                         facture.Num_facture

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => facture.Num_facture = __value, facture.Num_facture))));
                __builder2.AddAttribute(16, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => facture.Num_facture));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __Blazor.comuneProject.Client.Pages.facture.AddFacture.TypeInference.CreateValidationMessage_0(__builder2, 18, 19, 
#nullable restore
#line 15 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\AddFacture.razor"
                                  () => facture.Num_facture

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "mb-3");
                __builder2.AddMarkupContent(23, "<label for=\"Designation\" class=\"form-label\">Désignation</label>\r\n        ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "col-md-4");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\AddFacture.razor"
                                                         facture.Designation

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => facture.Designation = __value, facture.Designation))));
                __builder2.AddAttribute(30, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => facture.Designation));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __Blazor.comuneProject.Client.Pages.facture.AddFacture.TypeInference.CreateValidationMessage_1(__builder2, 32, 33, 
#nullable restore
#line 22 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\AddFacture.razor"
                                  () => facture.Designation

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n    ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "mb-3");
                __builder2.AddMarkupContent(37, "<label for=\"Date_facture\" class=\"form-label\">Date de facture</label>\r\n        ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "col-md-4");
                __Blazor.comuneProject.Client.Pages.facture.AddFacture.TypeInference.CreateInputDate_2(__builder2, 40, 41, "form-control", 42, 
#nullable restore
#line 27 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\AddFacture.razor"
                                                         facture.Date_facture

#line default
#line hidden
#nullable disable
                , 43, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => facture.Date_facture = __value, facture.Date_facture)), 44, () => facture.Date_facture);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n        ");
                __Blazor.comuneProject.Client.Pages.facture.AddFacture.TypeInference.CreateValidationMessage_3(__builder2, 46, 47, 
#nullable restore
#line 29 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\AddFacture.razor"
                                  () => facture.Date_facture

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n    ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddMarkupContent(51, "<button type=\"submit\" class=\"btn btn-primary\">Sauvgardé</button>\r\n        ");
                __builder2.OpenElement(52, "button");
                __builder2.AddAttribute(53, "class", "btn btn-light");
                __builder2.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\AddFacture.razor"
                                                Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(55, "Annulé");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "E:\workflow\BlazorProject\comuneProject\comuneProject\Client\Pages\facture\AddFacture.razor"
       
    [Parameter]
    public Guid factureId { get; set; }
    protected string Title = "Add";
    protected facture facture = new();
    protected override async Task OnParametersSetAsync()
    {
        if (factureId != Guid.Empty)
        {
            Title = "Edit";
            facture = await Http.GetFromJsonAsync<facture>("api/factures/" + factureId);

        }
    }
    protected async Task Savefacture()
    {

        if (facture.Id != Guid.Empty)
        {
            await Http.PutAsJsonAsync("api/factures" + factureId, facture);

        }
        else
        {
            await Http.PostAsJsonAsync("api/factures", facture);
        }

        Cancel();
    }
    public void Cancel()
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
namespace __Blazor.comuneProject.Client.Pages.facture.AddFacture
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591