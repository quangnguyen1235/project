using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        IEnumerable<Student> GetByGrade(int id);
        Student GetById(int id);
        Student Create(Student student);
        Student Edit(Student student);
        bool Delete(int id);
    }
}
