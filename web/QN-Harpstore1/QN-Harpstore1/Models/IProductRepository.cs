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
        IEnumerable<Product> GetsToProducer(int? id);
        IEnumerable<Product> GetsToProType(int? id);

        ProductDetailViewModel Get(string id);
        Product Create(Product product);
        Product Edit(Product product);
        bool Delete(string id);
    }
}
