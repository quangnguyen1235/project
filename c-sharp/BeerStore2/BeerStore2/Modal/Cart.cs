using System;
using System.Collections.Generic;
using System.Text;

namespace BeerStore2.Modal
{
    class Cart
    {
        public bool paid { get; set; }
        public int total => Calculate();
        public string paymentTime { get; set; }
        public List<Product> products { get; set; }
        public int Calculate() {
            int total = 0;
            foreach(var item in products)
            {
                total += item.money;
            }
            return total;
        }
    }
}
