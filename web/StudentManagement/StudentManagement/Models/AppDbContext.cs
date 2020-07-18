using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().HasData(
            //    new Employee() { Id = 1, fullName = "Nguyễn Đăng Quang", email = "nguyendangquanghbt12b7@gmail.com", ava = "~/images/unknownPerson.jpg", departerment = Dept.IT },
            //    new Employee() { Id = 2, fullName = "Tôn Thất Anh Minh", email = "minhminh.codegym@gmail.com", ava = "~/images/unknownPerson.jpg", departerment = Dept.Payroll },
            //    new Employee() { Id = 3, fullName = "Nguyễn Xuân Trung", email = "xuantrung.nguyen@gmail.com", ava = "~/images/unknownPerson.jpg", departerment = Dept.IT }
            //);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
