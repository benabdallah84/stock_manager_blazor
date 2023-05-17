using comuneProject.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comuneProject.Client.Pages.services
{
    public class FournisseurService : IRepositoryFrontEnd<comuneProject.Shared.Models.fournisseur>
    {
        public Task<fournisseur> Add(fournisseur entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(fournisseur entity)
        {
            throw new NotImplementedException();
        }

        public Task<fournisseur> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<fournisseur>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(Guid id, fournisseur entity)
        {
            throw new NotImplementedException();
        }
    }
}
