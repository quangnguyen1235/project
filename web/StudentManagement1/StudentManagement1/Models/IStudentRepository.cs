using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement1.Models
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        IEnumerable<Student> GetByGrade(int id);
        Student GetById(int id);
        Student Create(Student student, int id);
        Student Edit(Student student);
        bool Delete(int id);
    }
}
