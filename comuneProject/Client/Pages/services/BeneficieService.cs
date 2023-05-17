using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using comuneProject.Shared.Models;

namespace comuneProject.Client.Pages.services
{
    public class BeneficieService : IRepositoryFrontEnd<comuneProject.Shared.Models.beneficie>
    {
        public Task<comuneProject.Shared.Models.beneficie> Add(comuneProject.Shared.Models.beneficie entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(comuneProject.Shared.Models.beneficie entity)
        {
            throw new NotImplementedException();
        }

        public Task<comuneProject.Shared.Models.beneficie> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<comuneProject.Shared.Models.beneficie>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(Guid id, comuneProject.Shared.Models.beneficie entity)
        {
            throw new NotImplementedException();
        }
    }
}
