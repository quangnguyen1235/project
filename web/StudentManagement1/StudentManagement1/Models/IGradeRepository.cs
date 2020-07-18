using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement1.Models
{
    public interface IGradeRepository
    {
        IEnumerable<Grade> GetAll();
        Grade Get(int id);
    }
}
