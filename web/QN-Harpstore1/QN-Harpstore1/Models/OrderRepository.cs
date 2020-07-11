using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext context;

        public OrderRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Order Create(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
            return order;
        }

        public bool Delete(string id)
        {
            var delOrder = context.Orders.Find(id);
            if (delOrder != null)
            {
                context.Orders.Remove(delOrder);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public Order Edit(Order order)
        {
            var editOrder = context.Orders.Attach(order);
            editOrder.State = EntityState.Modified;
            context.SaveChanges();
            return order;
        }

        public Order Get(string id)
        {
            return context.Orders.Find(id);
        }

        public IEnumerable<Order> Gets()
        {
            return context.Orders;
        }
    }
}
