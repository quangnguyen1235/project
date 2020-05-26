using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CoffeeShopManagement.Class
{
    class Bill
    {
        public DateTime timeIn { get; set; }
        public DateTime timeOut { get; set; }
        public int sumTotal { get; set; }
        public int tatableNo { get; set; }
        public List<OrderDetails> orderDetails { get; set; }
        public void Sum()
        {
            foreach (var item in orderDetails)
            {
                sumTotal += item.money;
            }
        }
    }
}
