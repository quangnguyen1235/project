using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopManagement.Class
{
    class Oder
    {
        public int tableNo { get; set; }
        public bool paid { get; set; }
        public DateTime timeIn { get; set; }
        public List<OrderDetails> orderDetails { get; set; }
        public Oder(int tableNo, OrderDetails newitem)
        {
            this.tableNo = tableNo;
            paid = false;
            timeIn = System.DateTime.Now;
            orderDetails.Add(newitem);
        }
    }
}
