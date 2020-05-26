using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopManagement.Class
{
    class OrderDetails
    {
        public string foodName { get; set; }
        public int price { get; set; }
        public int qlt { get; set; }
        public int money => Calculate();
        public int Calculate()
        {
            int money = 0;
            return money = qlt * price;
        }
        public OrderDetails(string foodName, int price, int qlt)
        {
            this.foodName = foodName;
            this.price = price;
            this.qlt = qlt;
        }
    }
}
