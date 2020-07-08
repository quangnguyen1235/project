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
        public IEnumerable<Producer> Gets()
        {
            return dbContext.Producers;
        }
    }
}
