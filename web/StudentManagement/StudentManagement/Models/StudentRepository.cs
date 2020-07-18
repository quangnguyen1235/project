using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext context;

        public StudentRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Student Create(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return student;
        }

        public bool Delete(int id)
        {
            var delStudent = context.Students.Find(id);
            if (delStudent != null)
            {
                context.Students.Remove(delStudent);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public Student Edit(Student student)
        {
            var editEmp = context.Students.Attach(student);
            editEmp.State = EntityState.Modified;
            context.SaveChanges();
            return student;
        }

        public Student GetById(int id)
        {
            var data = (from student in context.Students
                        join grade in context.Grades
                        on student.GradeId equals grade.GradeId
                        where student.StudentId == id
                        select new Student
                        {
                            StudentId = student.StudentId,
                            GradeId = grade.GradeId,
                            Grade = grade,
                            StudentEmail = student.StudentEmail,
                            StudentDob = student.StudentDob,
                            StudentGender = student.StudentGender,
                            StudentName = student.StudentName,
                        }).FirstOrDefault();
            return data;
        }

        public IEnumerable<Student> GetAll()
        {
            var data = (from student in context.Students
                        join grade in context.Grades
                        on student.GradeId equals grade.GradeId
                        select new Student
                        {
                            StudentId = student.StudentId,
                            GradeId = grade.GradeId,
                            Grade = grade,
                            StudentEmail = student.StudentEmail,
                            StudentDob = student.StudentDob,
                            StudentGender = student.StudentGender,
                            StudentName = student.StudentName,
                        }
                        );
            return data;
        }

        public IEnumerable<Student> GetByGrade(int id)
        {

            var data = (from p in context.Students
                        where p.StudentId == id
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
