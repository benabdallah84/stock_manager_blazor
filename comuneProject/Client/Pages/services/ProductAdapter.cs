using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.Blazor;

namespace comuneProject.Client.Pages.services
{
    public class ProductAdapter: DataAdaptor
    {
        public override Task<object> ReadAsync(DataManagerRequest dataManagerRequest, string key = null)
        {
            return base.ReadAsync(dataManagerRequest, key);
        }
    }
}
