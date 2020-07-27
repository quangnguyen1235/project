using Harpstore.Domain.Request;
using Harpstore.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Harpstore.BAL.Interface
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<ModifyProduct> Save(Product Request);
        Task<ModifyProduct> Delete(int id);
        Task<IEnumerable<Product>> Search(string keyword);
        Task<IEnumerable<Product>> GetbyProducerId(int id);
        Task<IEnumerable<Product>> GetbyProTypeId(int id);
    }
}
