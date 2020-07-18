using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement1.Models
{
    public class GradeRepository : IGradeRepository
    {
        private readonly AppDbContext context;

        public GradeRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Grade Get(int id)
        {
            var data = context.Grades.Find(id);
            return data;
        }

        public IEnumerable<Grade> GetAll()
        {
            return context.Grades;
        }
    }
}
