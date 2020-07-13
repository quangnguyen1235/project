using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Models
{
    public interface IOrderRepository
    {
        Order Get(string id);
        IEnumerable<Order> Gets();
        bool Delete(string id);
        Order Create(Order order);
        Order Edit(Order order);
        void Save();
    }
}
