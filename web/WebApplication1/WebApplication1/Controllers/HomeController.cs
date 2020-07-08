using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository employeerepository;
        public HomeController()
        {
            employeerepository = new EmployeeRepository();
        }
        //attribute router
        [Route("~/")]
        [Route("Home")]
        [Route("Home/Index")]
        public ViewResult Index()
        {
            //ViewData["employee"] = employeerepository.Gets();

            ViewBag.Employess = employeerepository.Gets();
            return View();
        }
        //public ViewResult Details(int id)
        //{
        //    ViewBag.Employee = employeerepository.Get(id);
        //    return View();
        //}
        //public ViewResult Details(int id)
        //{
        //    var emp = employeerepository.Get(id);
        //    return View(emp);
            
        //}
        public ViewResult Details (int id)
        {
            var detailViewModel = new HomeDetailViewModel()
            {
                employee = employeerepository.Get(id),
                titleName = "Details"
            };
            return View(detailViewModel);
        }
    }
}
