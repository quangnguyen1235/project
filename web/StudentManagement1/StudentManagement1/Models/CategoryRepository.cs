using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement1.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext context;

        public CategoryRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Category Get(int id)
        {
            var data = context.Categories.Find(id);
            return data;
        }

        public IEnumerable<Category> GetAll()
        {
            return context.Categories;
        }
    }
}
