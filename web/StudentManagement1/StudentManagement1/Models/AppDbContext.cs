using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>().HasData(
                new Grade() { GradeId = 1, GradeName = "C#" },
                new Grade() { GradeId = 2, GradeName = "Java"},
                new Grade() { GradeId = 3, GradeName = "C++" },
                new Grade() { GradeId = 4, GradeName = "Php" },
                new Grade() { GradeId = 5, GradeName = "Sql" }
            );
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
