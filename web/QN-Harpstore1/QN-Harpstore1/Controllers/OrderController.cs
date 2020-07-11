using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using QN_Harpstore1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Controllers
{
    public class OrderController: Controller
    {
        private readonly IProductRepository productRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IOrderDetailRepository orderDetailRepository;
        private readonly IOrderRepository orderRepository;

        public OrderController(IProductRepository productRepository, IWebHostEnvironment webHostEnvironment,
            IOrderDetailRepository orderDetailRepository, IOrderRepository orderRepository)
        {
            this.productRepository = productRepository;
            this.webHostEnvironment = webHostEnvironment;
            this.orderDetailRepository = orderDetailRepository;
            this.orderRepository = orderRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
