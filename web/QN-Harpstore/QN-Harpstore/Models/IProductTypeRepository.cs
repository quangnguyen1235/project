using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore.Models
{
    public interface IProductTypeRepository
    {
        IEnumerable<ProductType> Gets();
    }
}
