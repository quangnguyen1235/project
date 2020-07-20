using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement1.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
        Category Get(int id);
    }
}
