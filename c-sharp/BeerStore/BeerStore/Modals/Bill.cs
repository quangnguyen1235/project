using System;
using System.Collections.Generic;
using System.Text;

namespace BeerStore.Modals
{
    class Bill
    {
        public Cart cart { get; set; }
        public DateTime paymentTime { get; set; }
        public int total { get; set; }
    }
}
