using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement1.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();
        IEnumerable<Book> GetByGrade(int id);
        Book GetById(int id);
        Book Create(Book book, int id);
        Book Edit(Book book);
        bool Delete(int id);
    }
}
