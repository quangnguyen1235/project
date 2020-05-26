using System;
using System.Collections.Generic;
using System.Text;

namespace BeerStore.Modals
{
    class Inventory
    {
        public string name { get; set; }
        public int price { get; set; }
        public int qlt { get; set; }
        public override string ToString()
        {
            return $"Name: {name}\t Qlt: {qlt}\t Price: {price}";
        }
    }
}
