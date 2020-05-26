using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using BeerStore2.Modal;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace BeerStore2.Service
{
    class JsonService
    {
        private string database;
        private string outputBill;
        private WareHouse wareHouse;
        private Cart cart;
        private Bill bill;
        public JsonService(string database, string outputBill)
        {
            this.database = database;
            this.outputBill = outputBill;
            wareHouse = new WareHouse()
            {
                inventories = new List<Inventory>()
            };
            cart = new Cart()
            {
                products = new List<Product>()
            };
            bill = new Bill()
            {
                carts = new List<Cart>()
            };
        }
        public void ReadDatabase()
        {
            using StreamReader sr = File.OpenText(database);
            var obj = sr.ReadToEnd();
            wareHouse = JsonConvert.DeserializeObject<WareHouse>(obj);
        }
        public void WriteBill()
        {
            using StreamWriter sw = File.CreateText(outputBill);
            var data = JsonConvert.SerializeObject(cart);
            sw.Write(data);
        }
        public void ReWrireDatabase()
        {
            using StreamWriter sw = File.CreateText(database);
            var data = JsonConvert.SerializeObject(wareHouse);
            sw.Write(data);
        }
        public void AddEditProduct(string name, int qlt)
        {
            var posInWareHouse = CheckInDatabase(name, qlt);
            var posInCart = CheckInCart(name);
            if(posInCart > -1)
            {
                cart.products[posInCart].qlt += qlt;
                if (cart.products[posInCart].qlt <= 0)
                {
                    cart.products.RemoveAt(posInCart);
                }
            }
            else
            {
                cart.products.Add(new Product(name, qlt, wareHouse.inventories[posInWareHouse].price));
            }
        }
        public void ShowCart()
        {
            foreach (var item in cart.products)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void RemoveCart()
        {
            cart.products.RemoveRange(0, cart.products.Count);
        }
        //public object CheckBill()
        //{
        //    foreach(var item in bill.carts)
        //    {
        //        if (item.paid)
        //        {
        //            return item;
        //        }
        //    }
        //    return null;
        //}
        public void PrintBill()
        {
            //object obj = CheckBill();
            cart.paid = true;
            cart.paymentTime = System.DateTime.Now.ToString("dd/MM/yyyy_hh:mm:ss tt");
            foreach(var item in cart.products)
            {
                RemoveRemainInWareHouse(item.name, item.qlt);
            }
            WriteBill();
            RemoveCart();
        }
        public void RemoveRemainInWareHouse(string name, int qlt)
        {
            var pos = CheckInDatabase(name, qlt);
            wareHouse.inventories[pos].qlt -= qlt;
            ReWrireDatabase();
        }
        private int CheckInDatabase(string name, int qlt)
        {
            for(int i = 0; i < wareHouse.inventories.Count; i++)
            {
                if(wareHouse.inventories[i].name.Equals(name) && qlt <= wareHouse.inventories[i].qlt)
                {
                    return i;
                }
            }
            return -1;
        }
        private int CheckInCart(string name)
        {
            for(int i = 0; i < cart.products.Count; i++)
            {
                if (cart.products[i].name.Equals(name))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
