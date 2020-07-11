using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Models
{
    public class ProTypeRepository : IProTypeRepository
    {
        private readonly AppDbContext context;

        public ProTypeRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Protype Get(int id)
        {
            var data = context.Protypes.Find(id);
            return data;
        }

        public IEnumerable<Protype> Gets()
        {
            return context.Protypes;
        }
    }
}
