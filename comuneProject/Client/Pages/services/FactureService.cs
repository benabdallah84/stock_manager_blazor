using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace comuneProject.Client.Pages.services
{
    public class FactureService : IRepositoryFrontEnd<comuneProject.Shared.Models.facture>
    {
        public Task<comuneProject.Shared.Models.facture> Add(comuneProject.Shared.Models.facture entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(comuneProject.Shared.Models.facture entity)
        {
            throw new NotImplementedException();
        }

        public Task<comuneProject.Shared.Models.facture> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<comuneProject.Shared.Models.facture>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(Guid id, comuneProject.Shared.Models.facture entity)
        {
            throw new NotImplementedException();
        }
    }
}
