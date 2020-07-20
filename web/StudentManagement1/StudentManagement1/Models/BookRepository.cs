using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement1.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext context;

        public BookRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Book Create(Book book, int id)
        {
            var newBook = book;
            newBook.CategoryId = id;
            context.Books.Add(newBook);
            context.SaveChanges();
            return newBook;
        }

        public bool Delete(int id)
        {
            var delBook = context.Books.Find(id);
            if (delBook != null)
            {
                context.Books.Remove(delBook);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public Book Edit(Book book)
        {
            var editBook = context.Books.Attach(book);
            editBook.State = EntityState.Modified;
            context.SaveChanges();
            return book;
        }

        public Book GetById(int id)
        {
            var data = (from book in context.Books
                        join category in context.Categories
                        on book.CategoryId equals category.CategoryId
                        where book.BookId == id
                        select new Book
                        {
                            BookId = book.BookId,
                            CategoryId = category.CategoryId,
                            Category = category,
                            ShortDesCription = book.ShortDesCription,
                            BookAuthor = book.BookAuthor,
                            BookName = book.BookName,
                            Qlt = book.Qlt,
                            Year = book.Year
                        }).FirstOrDefault();
            return data;
        }

        public IEnumerable<Book> GetAll()
        {
            var data = (from book in context.Books
                        join category in context.Categories
                        on book.CategoryId equals category.CategoryId
                        select new Book
                        {
                            BookId = book.BookId,
                            CategoryId = category.CategoryId,
                            Category = category,
                            ShortDesCription = book.ShortDesCription,
                            BookAuthor = book.BookAuthor,
                            BookName = book.BookName,
                            Qlt = book.Qlt,
                            Year = book.Year
                        });
            return data;
        }

        public IEnumerable<Book> GetByGrade(int id)
        {

            var data = (from p in context.Books
                        where p.CategoryId == id
                        select p);
            //select new Product
            //{
            //    ProductId = p.ProductId,
            //    ProductAvatar = p.ProductAvatar,
            //    ProductName = p.ProductName,
            //    ProductPrice = p.ProductPrice,
            //    ProducerId = p.ProducerId,
            //    ProductTypeId = p.ProductTypeId,
            //    FullDescription = p.FullDescription
            //});
            return data;
        }
    }
}
