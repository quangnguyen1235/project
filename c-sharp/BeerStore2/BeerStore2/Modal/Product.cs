using System;
using System.Collections.Generic;
using System.Text;

namespace BeerStore2.Modal
{
    class Product
    {
        public string name { get; set; }
        public int qlt { get; set; }
        public int price { get; set; }
        public int money { get; set; }
        public Product (string name, int qlt, int price)
        {
            this.name = name;
            this.qlt = qlt;
            this.price = price;
            this.money = qlt* price;
        }
        public override string ToString()
        {
            return $"Name: {name}\t Qlt: {qlt}\t Price: {price}\t Money: {money}";
        }
    }
}
