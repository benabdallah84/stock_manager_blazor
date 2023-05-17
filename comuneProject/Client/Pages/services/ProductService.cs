using comuneProject.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace comuneProject.Client.Pages.services
{
    public class ProductService : IRepositoryFrontEnd<product>
    {
       
             
        private readonly HttpClient http;

        public ProductService(HttpClient httpClient)
        {
            this.http = httpClient;
        }
        public Task<product> Add(product entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(product entity)
        {
            throw new NotImplementedException();
        }

        public Task<product> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<product>> GetAll()
        {
            return await http.GetFromJsonAsync< IEnumerable < product >> ("api/products");
        }

        public Task Update(Guid id, product entity)
        {
            throw new NotImplementedException();
        }
    }
}
