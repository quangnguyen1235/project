using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.Modal
{
    class OrderData
    {
        public List<Order> orders { get; set; }
        public void FindByCustomer(string name, string address)
        {
            foreach(var item in orders)
            {
                if(item.customer.address == address && item.customer.name == name)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
