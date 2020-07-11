using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using QN_Harpstore1.Models;
using QN_Harpstore1.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IProducerRepository producerRepository;
        private readonly IProTypeRepository protypeRepository;

        public HomeController(IProductRepository productRepository, IWebHostEnvironment webHostEnvironment, IProducerRepository producerRepository, IProTypeRepository protypeRepository)
        {
            this.productRepository = productRepository;
            this.webHostEnvironment = webHostEnvironment;
            this.producerRepository = producerRepository;
            this.protypeRepository = protypeRepository;
        }
        [Authorize]
        public ViewResult Management()
        {
            IEnumerable<Product> products = productRepository.Gets();
            return View(products);
        }
        public ViewResult Index()
        {
            IEnumerable<Product> products = productRepository.Gets();
            return View(products);
        }
        public ViewResult Details(string id)
        {

            var detailViewModel = new HomeDetailViewModel()
            {
                product = productRepository.Get(id),
                Title = "Product Details",
            };
            return View(detailViewModel);
        }
        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.ProductType = GetProductTypes();
            ViewBag.Producer = GetProducers();
            return View();
        }
        [HttpPost]
        public IActionResult Create(HomeCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product = new Product
                {
                    ProductName = model.ProductName,
                    ProductTypeId = model.ProductTypeId,
                    ProducerId = model.ProducerId,
                    FullDescription = model.FullDescription,
                    ShortDescription = model.ShortDescription,
                    ProductPrice = model.ProductPrice,
                    ProductId = $"{Guid.NewGuid()}"
                };
                var fileName = string.Empty;
                if (model.Image != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    fileName = $"{product.ProductId}_{model.Image.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Image.CopyTo(fs);
                    }
                    product.ProductAvatar = fileName;
                    var newProduct = productRepository.Create(product);
                    //return RedirectToAction("Details", new { id = newProduct.ProductId });
                    return RedirectToAction("Management");
                }
            }
            return View();
        }
        [Authorize]
        [HttpGet]
        public IActionResult Edit(string id)
        {
            ViewBag.ProductType = GetProductTypes();
            ViewBag.Producer = GetProducers();
            var product = productRepository.Get(id);
            var editProduct = new HomeEditViewModel
            {
                avaPath = product.ProductAvatar,
                id = product.ProductId,
                ProductName = product.ProductName,
                ProductPrice = product.ProductPrice,
                ProducerId = product.ProducerId,
                ProductProducerName = product.ProductProducerName,
                ProductTypeId = product.ProductTypeId,
                ProductTypeName = product.ProductTypeName,
                FullDescription = product.FullDescription,
                ShortDescription = product.ShortDescription,
            };
            return View(editProduct);
        }
        [HttpPost]
        public IActionResult Edit(HomeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product = new Product
                {
                    ProductId = model.id,
                    ProductAvatar = model.avaPath,
                    ProducerId = model.ProducerId,
                    ProductName = model.ProductName,
                    ProductPrice = model.ProductPrice,
                    ProductTypeId = model.ProductTypeId,
                    FullDescription = model.FullDescription,
                    ShortDescription = model.ShortDescription,
                };
                var fileName = string.Empty;
                if (model.Image != null)
                {
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    fileName = $"{product.ProductId}_{model.Image.FileName}";
                    var filePath = Path.Combine(uploadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Image.CopyTo(fs);
                    }
                    product.ProductAvatar = fileName;
                    if (!string.IsNullOrEmpty(model.avaPath))
                    {
                        string delFile = Path.Combine(webHostEnvironment.WebRootPath, "images", model.avaPath);
                        System.IO.File.Delete(delFile);
                    }
                }
                var editProduct = productRepository.Edit(product);
                if (editProduct != null)
                {
                    return RedirectToAction("Management");
                    //return RedirectToAction("Details", new { id = editProduct.ProductId });
                }
            }
            return View();
        }
        public IActionResult Remove(string id)
        {
            var delProduct = productRepository.Get(id);
            string dellFile = Path.Combine(webHostEnvironment.WebRootPath, "images", delProduct.ProductAvatar);
            System.IO.File.Delete(dellFile);
            if (productRepository.Delete(id))
            {
                return RedirectToAction("Management");
            }
            return View();
        }
        private List<Protype> GetProductTypes()
        {
            return protypeRepository.Gets().ToList();
        }
        private List<Producer> GetProducers()
        {
            return producerRepository.Gets().ToList();
        }
        
    }
}
