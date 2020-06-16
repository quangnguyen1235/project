using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository employeerepository;
        public HomeController()
        {
            employeerepository = new EmployeeRepository();
        }
        public ViewResult Index()
        {
            //ViewData["employee"] = employeerepository.Gets();

            ViewBag.Employess = employeerepository.Gets();
            return View();
        }
        public ViewResult Details(int id)
        {
            ViewBag.Employee = employeerepository.Get(id);
            return View();
        }
    }
}
