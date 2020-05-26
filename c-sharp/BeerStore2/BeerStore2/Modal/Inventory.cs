using System;
using System.Collections.Generic;
using System.Text;

namespace BeerStore2.Modal
{
    class Inventory
    {
        public string name { get; set; }
        public int qlt { get; set; }
        public int price { get; set; }
        public override string ToString()
        {
            return $"Name: {name}\t Remain: {qlt}\t Price: {price}";
        }
    }
}
