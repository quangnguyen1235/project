using Harpstore.BAL.Interface;
using Harpstore.DAL.Interface;
using Harpstore.Domain.Request;
using Harpstore.Domain.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace Harpstore.API.Controllers
{
    [ApiController]
    public class ProductController: ControllerBase
    {
        private readonly IProductService productService;
        private readonly ILogger<ProductController> logger;

        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            this.productService = productService;
            this.logger = logger;
        }
        [HttpDelete]
        [Route("/api/product/delete/{id}")]
        public async Task<ModifyProduct> Delete(int id)
        {
            return await productService.Delete(id);
        }
        [HttpGet]
        [Route("/api/product/getAll")]
        public async Task<IEnumerable<Product>> GetAll()
        {
            return await productService.GetAll();
        }
        [HttpGet]
        [Route("/api/product/getById/{id}")]
        public async Task<Product> GetById(int id)
        {
            return await productService.GetById(id);
        }
        [HttpGet]
        [Route("/api/product/producer/{id}")]
        public async Task<IEnumerable<Product>> GetbyProducerId(int id)
        {
            return await productService.GetbyProducerId(id);
        }
        [HttpGet]
        [Route("/api/product/protype/{id}")]
        public async Task<IEnumerable<Product>> GetbyProTypeId(int id)
        {
            return await productService.GetbyProTypeId(id);
        }

        [HttpPost]
        [Route("/api/product/save")]
        public async Task<ModifyProduct> Save(Product Request)
        {
            return await productService.Save(Request);
        }
        [HttpGet]
        [Route("/api/product/search")]
        public async Task<IEnumerable<Product>> Search(string keyword)
        {
            return await productService.Search(keyword);
        }
    }
}
