using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Models
{
    public class ProducerRepositoty : IProducerRepository
    {
        private readonly AppDbContext dbContext;

        public ProducerRepositoty(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Producer Get(int id)
        {
            var data = dbContext.Producers.Find(id);
            return data;
        }

        public IEnumerable<Producer> Gets()
        {
            return dbContext.Producers;
        }
    }
}
