using System;
using System.Collections.Generic;
using System.Text;

namespace BeerStore.Modals
{
    class Product
    {
        public string name { get; set; }
        public int price { get; set; }
        public int qlt { get; set; }
        public int money { get; set; }
        public Product(string name, int price, int qlt)
        {
            this.name = name;
            this.price = price;
            this.qlt = qlt;
            this.money = price * qlt;
        }
        public override string ToString()
        {
            return $"Name: {name}\t Qlt: {qlt}\t Price: {price}\t Money: {money} ";
        }
    }
}
