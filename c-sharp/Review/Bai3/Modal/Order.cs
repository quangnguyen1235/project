using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.Modal
{
    class Order
    {
        public int id { get; set; }
        public bool paid { get; set; }
        public Customer customer { get; set; }
        public List<Product> products { get; set; }
        public bool ChangeStatus(string status)
        {
            return paid = bool.Parse(status);
        }
    }
}
