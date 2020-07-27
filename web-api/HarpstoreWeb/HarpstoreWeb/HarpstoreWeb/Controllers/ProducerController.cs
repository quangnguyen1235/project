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

namespace HarpstoreWeb.Controllers
{
    public class ProducerController : Controller
    {
        private readonly ILogger<ProducerController> _logger;

        public ProducerController(ILogger<ProducerController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    var listProducer = new List<ProducerView>();
        //    listProducer = ApiHelper<List<ProducerView>>.HttpGetAsync(apiUrl: $"{Helper.ApiUrl}api/producer/getAll");
        //    return View(listProducer);
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
        public ViewResult Index()
        {
            return View();
        }
        public JsonResult GetAll()
        {
            var listProducer = new List<Producer>();
            listProducer = ApiHelper<List<Producer>>.HttpGetAsync(apiUrl: $"{Helper.ApiUrl}api/producer/getAll");
            return Json(new { listProducer });
        }
    }
}
