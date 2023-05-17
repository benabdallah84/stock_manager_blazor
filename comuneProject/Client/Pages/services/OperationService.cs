using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comuneProject.Client.Pages.services
{
    public class OperationService : IRepositoryFrontEnd<comuneProject.Shared.Models.operation>
    {
        public Task<comuneProject.Shared.Models.operation> Add(comuneProject.Shared.Models.operation entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(comuneProject.Shared.Models.operation entity)
        {
            throw new NotImplementedException();
        }

        public Task<comuneProject.Shared.Models.operation> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<comuneProject.Shared.Models.operation>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(Guid id, comuneProject.Shared.Models.operation entity)
        {
            throw new NotImplementedException();
        }
    }
}
