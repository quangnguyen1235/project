using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.Modal
{
    class OrderData
    {
        List<Order> orders { get; set; }
        public Order Find(int id)
        {
            foreach(var item in orders)
            {
                if(item.id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public List<Order> FindByCustomer(string name, string address)
        {
            List<Order> findList = new List<Order>();
            foreach(var item in orders)
            {
                if(item.customer.address == address && item.customer.name == name)
                {
                    findList.Add(item);
                }
            }
            return findList;
        }
    }
}
