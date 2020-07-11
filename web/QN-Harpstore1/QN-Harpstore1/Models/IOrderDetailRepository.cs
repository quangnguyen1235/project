using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Models
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetAll();
        IEnumerable<OrderDetail> Gets(string orderId);
        OrderDetail Get(string id);
        bool Delete(string id);
        OrderDetail Create(OrderDetail orderDetail);
        OrderDetail Edit(OrderDetail orderDetail);
    }
}
