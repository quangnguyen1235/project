using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentManagement.Models;
using StudentManagement.ViewModel;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IGradeRepository gradeRepository;
        private readonly IWebHostEnvironment webHostEnvironment;

        public HomeController(IStudentRepository studentRepository, IGradeRepository gradeRepository, IWebHostEnvironment webHostEnvironment)
        {
            this.studentRepository = studentRepository;
            this.gradeRepository = gradeRepository;
            this.webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            IEnumerable<Grade> grades = gradeRepository.GetAll();
            return View(grades);
        }

        public IActionResult StudentByGrade(int id)
        {
            try
            {
                ViewBag.Grade = gradeRepository.Get(id);
                IEnumerable<Student> students = studentRepository.GetByGrade(id);
                return View(students);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            try
            {
                ViewBag.Grade = GetGrades();
                return View();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [HttpPost]
        public IActionResult Create(Student model)
        {

            if (ModelState.IsValid)
            {
                var student = new Student
                {
                    StudentName = model.StudentName,
                    GradeId = model.GradeId,
                    StudentDob = model.StudentDob,
                    StudentGender = model.StudentGender,
                    StudentEmail = model.StudentEmail,
                };

                var newStudent = studentRepository.Create(student);
                return RedirectToAction("Details", new { id = newStudent.StudentId });
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
           
                ViewBag.Grade = GetGrades();
                var student = studentRepository.GetById(id);
                var editProduct = new HomeEditViewModel
                {
                    Id = student.StudentId,
                    StudentId = student.StudentId,
                    StudentDob = student.StudentDob,
                    StudentEmail = student.StudentEmail,
                    StudentGender = student.StudentGender,
                    StudentName = student.StudentName,
                    GradeId = student.GradeId
                };
                return View(editProduct);
           
        }
        [HttpPost]
        public IActionResult Edit(HomeEditViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var student = new Student
                    {
                        StudentId = model.StudentId,
                        StudentDob = model.StudentDob,
                        StudentEmail = model.StudentEmail,
                        StudentGender = model.StudentGender,
                        StudentName = model.StudentName,
                        GradeId = model.GradeId
                    };
                   
                    var editStudent = studentRepository.Edit(student);
                    if (student != null)
                    {
                        RedirectToAction("Details", new { id = editStudent.StudentId });
                        //return RedirectToAction("Details", new { id = editProduct.ProductId });
                    }
                }
                return View();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public IActionResult Remove(int id)
        {
            try
            {
                var delStudent = studentRepository.GetById(id);
                if (studentRepository.Delete(id))
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public ViewResult Details(int id)
        {
            try
            {
                var student = studentRepository.GetById(id);
                var detailViewModel = new HomeDetailViewModel()
                {
                    student = studentRepository.GetById(id)
                };
                return View(detailViewModel);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private List<Grade> GetGrades()
        {
            return gradeRepository.GetAll().ToList();
        }
    }
}
