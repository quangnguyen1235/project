using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.Modal
{
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int qlt { get; set; }
        public int price { get; set; }
        public int money { get; set; }
        public Product(int id, string name, int qlt, int price)
        {
            this.id = id;
            this.name = name;
            this.qlt = qlt;
            this.price = price;
            this.money = qlt * price;
        }
        public override string ToString()
        {
            return $"Id: {id}\t Name: {name}\t Price: {price}\t Remain: {qlt}\t Money: {money}";
        }
    }
}
