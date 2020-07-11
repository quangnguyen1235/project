using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using QN_Harpstore1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IProducerRepository producerRepository;
        private readonly IProTypeRepository protypeRepository;

        public CategoryController(IProductRepository productRepository, IWebHostEnvironment webHostEnvironment, IProducerRepository producerRepository, IProTypeRepository protypeRepository)
        {
            this.productRepository = productRepository;
            this.webHostEnvironment = webHostEnvironment;
            this.producerRepository = producerRepository;
            this.protypeRepository = protypeRepository;
        }
        public IActionResult IndexProducer()
        {
            IEnumerable<Producer> producers = producerRepository.Gets();
            return View(producers);
        }
        public IActionResult IndexProType()
        {
            IEnumerable<Protype> proTypes = protypeRepository.Gets();
            return View(proTypes);
        }
        public IActionResult ProducerCategory(int id)
        {
            ViewBag.ProducerCategory = producerRepository.Get(id);
            IEnumerable<Product> products = productRepository.GetsToProducer(id);
            return View(products);
        }
        public IActionResult ProTypeCategory(int id)
        {
            ViewBag.ProtypeCategory = protypeRepository.Get(id);
            IEnumerable<Product> products = productRepository.GetsToProType(id);
            return View(products);
        }
        
    }
}
