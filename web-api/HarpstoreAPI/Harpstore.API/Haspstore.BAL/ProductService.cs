using Harpstore.BAL.Interface;
using Harpstore.DAL.Interface;
using Harpstore.Domain.Request;
using Harpstore.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Harpstore.BAL
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<ModifyProduct> Delete(int id)
        {
            return await productRepository.Delete(id);
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await productRepository.GetAll();
        }

        public async Task<Product> GetById(int id)
        {
            return await productRepository.GetById(id);
        }

        public async Task<IEnumerable<Product>> GetbyProducerId(int id)
        {
            return await productRepository.GetbyProducerId(id);
        }

        public async Task<IEnumerable<Product>> GetbyProTypeId(int id)
        {
            return await productRepository.GetbyProTypeId(id);
        }

        public async Task<ModifyProduct> Save(Product request)
        {
            return await productRepository.Save(request);
        }

        public async Task<IEnumerable<Product>> Search(string keyword)
        {
            return await productRepository.Search(keyword);
        }
    }
}
