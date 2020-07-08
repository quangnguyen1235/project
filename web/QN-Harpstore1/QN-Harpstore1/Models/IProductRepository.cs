using QN_Harpstore1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Gets();
        ProductDetailViewModel Get(string id);
        Product Create(Product product);
        Product Edit(Product product);
        bool Delete(string id);
    }
}
