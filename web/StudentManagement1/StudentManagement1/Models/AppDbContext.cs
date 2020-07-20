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
            modelBuilder.Entity<Category>().HasData(
                new Category() { CategoryId = 1, CategoryName = "C#" },
                new Category() { CategoryId = 2, CategoryName = "Java" },
                new Category() { CategoryId = 3, CategoryName = "C++" },
                new Category() { CategoryId = 4, CategoryName = "Php" },
                new Category() { CategoryId = 5, CategoryName = "Sql" }
            );
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
