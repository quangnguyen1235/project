using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.Modal
{
    class Inventory
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int remain { get; set; }
        public Inventory(int id, string name, int price, int remain)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.remain = remain;
        }
        public override string ToString()
        {
            return $"Id: {id}\t Name: {name}\t Price: {price}\t Remain: {remain}";
        }
    }
}
