using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comuneProject.Client.Pages.services
{
    public interface IRepositoryFrontEnd<TEntity>
    {
            Task<IEnumerable<TEntity>> GetAll();
            Task<TEntity> Get(Guid id);
            Task<TEntity> Add(TEntity entity);
            Task Update(Guid id, TEntity entity);
            Task Delete(TEntity entity);
    }
    
}
