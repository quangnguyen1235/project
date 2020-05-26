using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace BeerStore.Modals
{
    class Cart
    {
        public bool paid { get; set; }
        public int total => calculateTotal();
        public DateTime paymentTime { get; set; }
        public List<Product> products { get; set; }
        //public Cart(Product newProduct)
        //{
        //    paid = false;
        //    products.Add(newProduct);
        //    total = calculateTotal();
        //}
        public int calculateTotal()
        {
            int total = 0;
            foreach(var item in products)
            {
                total += item.money;
            }
            return total;
        }
    }
}
