using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentManagement1.Models;
using StudentManagement1.ViewModel;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository bookRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IWebHostEnvironment webHostEnvironment;

        public HomeController(IBookRepository bookRepository, ICategoryRepository categoryRepository, IWebHostEnvironment webHostEnvironment)
        {
            this.bookRepository = bookRepository;
            this.categoryRepository = categoryRepository;
            this.webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categories = categoryRepository.GetAll();
            return View(categories);
        }
        public IActionResult StudentByGrade(int id)
        {
            try
            {
                ViewBag.categories = categoryRepository.Get(id);
                IEnumerable<Book> books = bookRepository.GetByGrade(id);
                return View(books);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [HttpGet]
        public IActionResult Create(int id)
        {
            try
            {
                ViewBag.Category = categoryRepository.Get(id);
                return View();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [HttpPost]
        public IActionResult Create(Book model, int id)
        {

            if (ModelState.IsValid)
            {
                var book = new Book
                {
                    BookId = model.BookId,
                    CategoryId = id,
                    ShortDesCription = model.ShortDesCription,
                    BookAuthor = model.BookAuthor,
                    BookName = model.BookName,
                    Qlt = model.Qlt,
                    Year = model.Year
                    //StudentName = model.StudentName,
                    //GradeId = id,
                    //StudentDob = model.StudentDob,
                    //StudentGender = model.StudentGender,
                    //StudentEmail = model.StudentEmail,
                };

                var newBook = bookRepository.Create(book, id);
                return RedirectToAction("StudentByGrade", new { id = newBook.CategoryId });
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
           
                ViewBag.Category = GetGrades();
                var book = bookRepository.GetById(id);
                var editBook = new HomeEditViewModel
                {
                    Id = book.BookId,
                    CategoryId = book.CategoryId,
                    ShortDesCription = book.ShortDesCription,
                    BookAuthor = book.BookAuthor,
                    BookName = book.BookName,
                    Qlt = book.Qlt,
                    Year = book.Year
                    //StudentId = student.StudentId,
                    //StudentDob = student.StudentDob,
                    //StudentEmail = student.StudentEmail,
                    //StudentGender = student.StudentGender,
                    //StudentName = student.StudentName,
                    //GradeId = student.GradeId
                };
                return View(editBook);
           
        }
        [HttpPost]
        public IActionResult Edit(HomeEditViewModel model)
        {
                if (ModelState.IsValid)
                {
                    var book = new Book
                    {
                        BookId = model.Id,
                        CategoryId = model.CategoryId,
                        ShortDesCription = model.ShortDesCription,
                        BookAuthor = model.BookAuthor,
                        BookName = model.BookName,
                        Qlt = model.Qlt,
                        Year = model.Year
                        //StudentId = model.Id,
                        //StudentDob = model.StudentDob,
                        //StudentEmail = model.StudentEmail,
                        //StudentGender = model.StudentGender,
                        //StudentName = model.StudentName,
                        //GradeId = model.GradeId
                    };
                   
                    var editBook = bookRepository.Edit(book);
                    if (book != null)
                    {
                        return RedirectToAction("StudentByGrade", new { id = editBook.CategoryId });
                        //return RedirectToAction("Details", new { id = editProduct.ProductId });
                    }
                }
                return View();
        }
        public IActionResult Remove(int id)
        {
            try
            {
                var delBook = bookRepository.GetById(id);
                if (bookRepository.Delete(id))
                {
                    return RedirectToAction("StudentByGrade", new { id = delBook.CategoryId });
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
                var book = bookRepository.GetById(id);
                var detailViewModel = new HomeDetailViewModel()
                {
                    book = bookRepository.GetById(id)
                };
                return View(detailViewModel);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private List<Category> GetGrades()
        {
            return categoryRepository.GetAll().ToList();
        }
    }
}
