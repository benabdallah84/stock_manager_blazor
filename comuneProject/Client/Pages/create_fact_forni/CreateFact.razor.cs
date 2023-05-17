using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using comuneProject.Shared.Models;
using System.Net.Http.Json;
using Havit.Blazor.Components.Web.Bootstrap;
using Microsoft.JSInterop;

namespace comuneProject.Client.Pages.create_fact_forni
{
    public partial class CreateFact
    {

        [Inject]
        IJSRuntime JS { get; set; }

        [Parameter]
        public Guid fournisseurId { get; set; }
        protected string Title = "Add";
        protected string Id;

        protected bool IsDisabled = true;
        protected fournisseur fournisseur = new();
        protected product product = new();

        [Parameter]
        public Guid factureId { get; set; }

        protected comuneProject.Shared.Models.facture facture = new();
        protected override async Task OnParametersSetAsync()
        {
            if (fournisseurId != Guid.Empty)
            {
                Title = "Edit";
                fournisseur = await Http.GetFromJsonAsync<fournisseur>("api/fournisseurs/" + fournisseurId);

            }

            if (factureId != Guid.Empty)
            {
                Title = "Edit";
                facture = await Http.GetFromJsonAsync<comuneProject.Shared.Models.facture>("api/factures/" + factureId);

            }


        }
        
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {

                await JS.InvokeVoidAsync("ToggleForm", "div#facturForm", IsDisabled);
            }

        }

        private async Task ToggleDisableForm()
        {

            await JS.InvokeVoidAsync("ToggleForm", "div#fournisseurForm", IsDisabled);
            await JS.InvokeVoidAsync("ToggleForm", "div#facturForm", !IsDisabled);
            // await JS.InvokeVoidAsync("setGuidToForm", "div>Input#fournisseurLbl", Id);
            IsDisabled = !IsDisabled;

        }

        protected async Task Savefournisseur()
        {

            if (fournisseur.Id != Guid.Empty)
            {
                await Http.PutAsJsonAsync("api/fournisseurs" + fournisseurId, fournisseur);

            }
            else
            {

                var obj = await Http.PostAsJsonAsync("api/fournisseurs", fournisseur);
                await ToggleDisableForm();
                Id = obj.Headers.Location.Segments.ElementAt(3);
                if (Id != null)
                {
                    facture.FournisseurId = Guid.Parse(Id);
                }


            }


        }
        public void Cancel()
        {
            NavigationManager.NavigateTo("/fournisseur/details");
        }

        //facture code


        protected async Task Savefacture()
        {

            if (facture.Id != Guid.Empty)
            {
                await Http.PutAsJsonAsync("api/factures" + factureId, facture);

            }
            else
            {
                var obj = await Http.PostAsJsonAsync("api/factures", facture);
                await JS.InvokeVoidAsync("ToggleForm", "div#facturForm", !IsDisabled);
                Props.IdProps = obj.Headers.Location.Segments.ElementAt(3);


            }

            // Cancel2();

        }
        public void Cancel2()
        {
            NavigationManager.NavigateTo("/facture/details");
        }
        // toast
        [Inject] 
        protected Havit.Blazor.Components.Web.IHxMessengerService Messenger { get; set; }
        private void HandleAddInformationButtonClick()
        {
            Messenger.AddInformation(title: "Data encrypted", message: "All your data has been encrypted. To decrypt your data share $100 with all your teammates.");
        }

        private bool ActiveFormProp = true;

        private string ActiveForm => ActiveFormProp ? "collapse" : null;

        private void ActiveFcture()
        {
            ActiveFormProp = !ActiveFormProp;
        }
    }
}
