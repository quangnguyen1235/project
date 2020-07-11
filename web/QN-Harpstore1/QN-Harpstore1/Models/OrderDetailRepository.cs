using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace QN_Harpstore1.Models
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly AppDbContext context;

        public OrderDetailRepository(AppDbContext context)
        {
            this.context = context;
        }
        public OrderDetail Create(OrderDetail orderDetail)
        {
            context.OrderDetails.Add(orderDetail);
            context.SaveChanges();
            return orderDetail;
        }

        public bool Delete(string id)
        {
            var delOrderDetail = context.OrderDetails.Find(id);
            if (delOrderDetail != null)
            {
                context.OrderDetails.Remove(delOrderDetail);
                return context.SaveChanges() > 0;
            }
            return false;

        }

        public OrderDetail Edit(OrderDetail orderDetail)
        {
            var editOrderDetail = context.OrderDetails.Attach(orderDetail);
            editOrderDetail.State = EntityState.Modified;
            context.SaveChanges();
            return orderDetail;
        }

        public OrderDetail Get(string id)
        {
            return context.OrderDetails.Find(id);
        }

        public IEnumerable<OrderDetail> Gets(string orderId)
        {
            var data = (from orderDetail in context.OrderDetails
                        where orderDetail.OrderId == orderId
                        select orderDetail);
            return data;
        }
    }
}
