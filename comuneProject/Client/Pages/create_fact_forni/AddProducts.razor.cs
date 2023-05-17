using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using comuneProject.Shared.Models;
using System.Net.Http.Json;
using comuneProject.Client.Pages.services;

namespace comuneProject.Client.Pages.create_fact_forni
{
    public partial class AddProducts
    {
        [Inject]
        IJSRuntime JS { get; set; }
        [Parameter]
        public Guid productId { get; set; }
        public Guid factureId { get; set; }

        protected string Title = "Add";
        protected product product = new();
        protected int getQuantity = 0;
        protected string getMatricul = null;

        [Inject]
        protected IRepositoryFrontEnd<product> productService { get; set; }

        protected string propsFact = Props.IdProps;

        protected List<product>
            productList = null;

        protected override async Task OnParametersSetAsync()
        {
            if (productId != Guid.Empty)
            {
                Title = "Edit";
                product = await Http.GetFromJsonAsync<product>("api/products/" + productId);

            }
        }
        protected async Task Saveproduct()
        {

            if (product.Id != Guid.Empty)
            {
                await Http.PutAsJsonAsync("api/products" + productId, product);

            }
            else
            {
                //Console.WriteLine("factureID = "+ factureId);
                product.facturesId = factureId;
                await Http.PostAsJsonAsync("api/products", product);
            }

            await ViewEditedPorductsAsync();
        }
        public void Cancel()
        {
            NavigationManager.NavigateTo("/produit/details");
        }
        protected async Task SaveMultiProducts()
        {

            if (Props.IdProps != null)
            {
                factureId = Guid.Parse(Props.IdProps);

                if (getQuantity != 0)
                {
                    if (factureId != Guid.Empty)
                    {
                        Console.WriteLine("FACTUREID= " + factureId);

                        product.facturesId = factureId;
                        if (product.productType == categories.TypeProduit.Static)
                        {
                            for (int i = 1; i <= getQuantity; i++)
                            {

                                if (product.Matricul != null)
                                {
                                    string[] splitedMatricul = product.Matricul.Split('/');
                                    if (i == 1)
                                    {
                                        product.Quantity = 1;
                                        product.Matricul = getMatricul;
                                    }
                                    else
                                    {
                                        product.Quantity = 1;
                                        product.Matricul = (int.TryParse(splitedMatricul[splitedMatricul.Length - 1], out int result) ? (result + 1).ToString() : product.Matricul);
                                    }
                                }
                                else
                                {
                                    await JS.InvokeVoidAsync("Il faux insert le matricule!", "Warning!");
                                }
                                await Http.PostAsJsonAsync("api/products", product);
                            }
                        }
                        else
                        {
                            product.Quantity = getQuantity;
                            await Http.PostAsJsonAsync("api/products", product);
                        }
                    }
                    else
                    {
                        await JS.InvokeVoidAsync("Id de facture n'exist pas!", "Warning!");
                    }
                }
                else
                {
                    await JS.InvokeVoidAsync("Il faux insert la quntity!", "Warning!");
                }
            }

            await ViewEditedPorductsAsync();
        }




        protected async Task ViewEditedPorductsAsync()
        {
            productList = new();
            if (factureId != Guid.Empty)
            {

                productList = (await productService.GetAll()).Where(p => p.facturesId == factureId).ToList();
            }

            clearProduct();

        }
        protected void clearProduct() {
            product.Matricul = "";
            product.Designation = "";
            product.Quantity = 0;           
        
        }
    }
}
