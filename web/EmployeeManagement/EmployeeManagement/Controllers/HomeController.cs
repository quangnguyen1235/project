using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeReponsitory employeeReponsitory;
        private readonly IHostingEnvironment hostingEnvironment;
        public HomeController(IEmployeeReponsitory employeeReponsitory, IHostingEnvironment hostingEnvironment)
        {
            this.employeeReponsitory = employeeReponsitory;
            this.hostingEnvironment = hostingEnvironment;
        }
        public ViewResult Index()
        {
            IEnumerable<Employee> employees = employeeReponsitory.Gets();
            return View(employees);
        }
        public ViewResult Details(int id)
        {
            var detailViewModel = new HomeDetailViewModels()
            {
                myProperty = employeeReponsitory.Get(id),
                titleName = "Employee Details",
            };
            return View(detailViewModel);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(HomeCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee
                {
                    fullName = model.fullName,
                    departerment = model.departerment,
                    email = model.email,
                };
                var fileName = string.Empty;
                if (model.Image != null)
                {
                    string upLoadFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_{model.Image.FileName}";
                    var filePath = Path.Combine(upLoadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Image.CopyTo(fs);
                    }
                }
                employee.ava = fileName;
                var newEmp = employeeReponsitory.Create(employee);
                return RedirectToAction("Details", new { id = newEmp.Id });
            }
            return View();
        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            var employee = employeeReponsitory.Get(id);
            var empEdit = new HomeEditViewModel()
            {
                AvaPath = employee.ava,
                id = employee.Id,
                fullName = employee.fullName,
                email = employee.email,
                departerment = employee.departerment
            };
            return View(empEdit);
        }
        [HttpPost]
        public IActionResult Edit(HomeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    fullName = model.fullName,
                    email = model.email,
                    departerment = model.departerment,
                    Id = model.Id,
                    ava = model.AvaPath
                };
                var fileName = string.Empty;
                if (model.Image != null)
                {
                    string upLoadFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    fileName = $"{Guid.NewGuid()}_{model.Image.FileName}";
                    var filePath = Path.Combine(upLoadFolder, fileName);
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Image.CopyTo(fs);
                    }
                    employee.ava = fileName;
                    if (!string.IsNullOrEmpty(model.AvaPath))
                    {
                        string delFile = Path.Combine(hostingEnvironment.WebRootPath, "images", model.AvaPath);
                        System.IO.File.Delete(delFile);
                    }
                }
                var editEmp = employeeReponsitory.Edit(employee);
                if (editEmp != null)
                {
                    return RedirectToAction("Details", new { id = model.Id });
                }
            }
            return View();
        }
        public IActionResult Remove(int id)
        {
            if (employeeReponsitory.Delete(id))
            {

                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
