using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comuneProject.Shared.Models
{
    public class ProductDataResult
    {
        public IEnumerable<product> Products { get; set; }
        public int Count { get; set; }
    }
}
