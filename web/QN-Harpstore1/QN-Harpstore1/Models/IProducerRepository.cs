using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Models
{
    public interface IProducerRepository
    {
        IEnumerable<Producer> Gets();
        Producer Get(int id);
    }
}
