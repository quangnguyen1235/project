using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HarpstoreWeb.Models;
using HarpstoreWeb.Models.Producer;
using HarpstoreWeb.Common;
using HarpstoreWeb.Models.Product;
using HarpstoreWeb.Models.ProType;
using System.Security.Permissions;

namespace HarpstoreWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }
        public ViewResult OfProducer(int id)
        {
            var producer = new Producer();
            var listProType = new List<ProType>();
            var listProducer = new List<Producer>();
            listProducer = ApiHelper<List<Producer>>.HttpGetAsync(apiUrl: $"{Helper.ApiUrl}api/producer/getAll");
            listProType = ApiHelper<List<ProType>>.HttpGetAsync(apiUrl: $"{Helper.ApiUrl}api/protype/getAll");
            producer = ApiHelper<Producer>.HttpGetAsync(apiUrl: $"{Helper.ApiUrl}api/producer/getById/{id}");
            ViewBag.ListProType = listProType;
            ViewBag.ListProducer = listProducer;
            ViewBag.Producer = producer;
            return View();
        }
        public JsonResult GetbyProducer(int id)
        {
            var listProType = new List<ProType>();
            //var listProducer = new List<Producer>();
            var listProduct = new List<Product>();
            listProduct = ApiHelper<List<Product>>.HttpGetAsync(apiUrl: $"{Helper.ApiUrl}api/product/producer/{id}");
            //listProducer = ApiHelper<List<Producer>>.HttpGetAsync(apiUrl: $"{Helper.ApiUrl}api/producer/getAll");
            listProType = ApiHelper<List<ProType>>.HttpGetAsync(apiUrl: $"{Helper.ApiUrl}api/protype/getAll");
            //ViewBag.ProType = listProType;
            //ViewBag.Producer = listProducer;
            var dataProductView = (from product in listProduct
                        join protype in listProType
                        on product.ProTypeId equals protype.ProTypeId
                        select new ProductView
                        {
                            ProductId = product.ProductId,
                            ProductName = product.ProductName,
                            ProductPrice = product.ProductPrice,
                            AvataPath = product.AvataPath,
                            FullDescription = product.FullDescription,
                            ShortDescription = product.ShortDescription,
                            ProTypeName = protype.ProTypeName
                        });
            return Json(new { dataProductView });
        }
        //public JsonResult GetbyProtype(int id)
        //{
        //    var listProducer = new List<Producer>();
        //    var listProduct = new List<Product>();
        //    listProduct = ApiHelper<List<Product>>.HttpGetAsync(apiUrl: $"{Helper.ApiUrl}api/product/producer/{id}");
        //    listProducer = ApiHelper<List<Producer>>.HttpGetAsync(apiUrl: $"{Helper.ApiUrl}api/producer/getAll");
        //    var dataProductView = (from product in listProduct
        //                           join producer in listProducer
        //                           on product.ProducerId equals producer.ProducerId
        //                           select new ProductView
        //                           {
        //                               ProductId = product.ProductId,
        //                               ProductName = product.ProductName,
        //                               ProductPrice = product.ProductPrice,
        //                               AvataPath = product.AvataPath,
        //                               FullDescription = product.FullDescription,
        //                               ShortDescription = product.ShortDescription,
        //                               ProducerName = producer.ProducerName
        //                           });
        //    return Json(new { dataProductView });
        //}
        public ViewResult OfProType(int id)
        {
            var protype = ApiHelper<ProType>.HttpGetAsync(apiUrl: $"{Helper.ApiUrl}api/protype/getById/{id}");
            ViewBag.ProType = protype;
            var listProduct = ApiHelper<List<Product>>.HttpGetAsync(apiUrl: $"{Helper.ApiUrl}api/product/protype/{id}");
            var listproducer = ApiHelper<List<Producer>>.HttpGetAsync(apiUrl: $"{Helper.ApiUrl}api/producer/getAll");
            var dataProductView = (from product in listProduct
                                   join producer in listproducer
                                   on product.ProducerId equals producer.ProducerId
                                   select new ProductView
                                   {
                                       ProductId = product.ProductId,
                                       ProductName = product.ProductName,
                                       ProductPrice = product.ProductPrice,
                                       AvataPath = product.AvataPath,
                                       FullDescription = product.FullDescription,
                                       ShortDescription = product.ShortDescription,
                                       ProducerName = producer.ProducerName
                                   });
            return View(dataProductView);
        }
        public IActionResult Details(int id)
        {
            var product = ApiHelper<Product>.HttpGetAsync(apiUrl: $"{Helper.ApiUrl}api/product/getById/{id}");
            var protype = ApiHelper<ProType>.HttpGetAsync(apiUrl: $"{Helper.ApiUrl}api/protype/getById/{product.ProTypeId}");
            var producer = ApiHelper<Producer>.HttpGetAsync(apiUrl: $"{Helper.ApiUrl}api/producer/getById/{product.ProducerId}");
            var productDetails = new ProductView()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                ProductPrice = product.ProductPrice,
                AvataPath = product.AvataPath,
                FullDescription = product.FullDescription,
                ShortDescription = product.ShortDescription,
                ProTypeName = protype.ProTypeName,
                ProducerName = producer.ProducerName
            };
            return View(productDetails);
        }
        public JsonResult Save([FromBody] Product model)
        {
            //var product = ApiHelper<Product>.HttpGetAsync(apiUrl: $"{Helper.ApiUrl}api/product/getById/{model.ProductId}");
            var result = new SaveProductResult();
            result = ApiHelper<SaveProductResult>.HttpPostAsync(
                                                    $"{Helper.ApiUrl}api/product/save",
                                                    model
                                                );
            return Json(new { result });
        }
        public JsonResult Get(int id)
        {
            var result = new Product();
            result = ApiHelper<Product>.HttpGetAsync(
                                                    $"{Helper.ApiUrl}api/product/getById/{id}"
                                                );
            return Json(new { result });
        }
        public JsonResult Delete(int id)
        {
            var result = new SaveProductResult();
            result = ApiHelper<SaveProductResult>.HttpGetAsync(
                                                    $"{Helper.ApiUrl}api/product/delete/{id}",
                                                    "DELETE"
                                                );
            return Json(new { result });
        }
    }
}
