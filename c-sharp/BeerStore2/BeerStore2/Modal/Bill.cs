using System;
using System.Collections.Generic;
using System.Text;

namespace BeerStore2.Modal
{
    class Bill
    {
        public string paymentTime { get; set; }
        public List<Cart> carts { get; set; }
    }
}
