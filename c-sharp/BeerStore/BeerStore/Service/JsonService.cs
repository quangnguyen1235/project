using BeerStore.Modals;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;

namespace BeerStore.Service
{
    class JsonService
    {
        public WareHouse wareHouse;
        public Cart cart;
        public Cart bill;
        public  string database;
        public string outputBill { get; set; }
        public JsonService(string inputDatabase, string outputBill)
        {
            this.database = inputDatabase;
            this.outputBill = outputBill;
            wareHouse = new WareHouse()
            {
                inventories = new List<Inventory>()
            };
            cart = new Cart()
            {
                products = new List<Product>()
            };
        }
        public void ReadJson()
        {
            using (StreamReader sr = File.OpenText(database))
            {
                var obj = sr.ReadToEnd();
                wareHouse = JsonConvert.DeserializeObject<WareHouse>(obj);
            }
        }
        public void WriteJson()
        {
            using (StreamWriter sw = File.CreateText(outputBill))
            {
                var data = JsonConvert.SerializeObject(bill);
                sw.Write(data);
            }
            using (StreamWriter sw = File.CreateText(database))
            {
                var data = JsonConvert.SerializeObject(wareHouse);
                sw.Write(data);
            }
        }
        public void Menu()
        {
            Console.WriteLine("------------Menu------------");
            foreach (var item in wareHouse.inventories)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("----------------------------");
        }
        public void ShowCart()
        {
            Console.WriteLine("------------Cart------------");
            foreach (var item in cart.products)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine($"Total: {cart.total}");
            Console.WriteLine("----------------------------");
        }
        public void RemoveCart()
        {
            Console.WriteLine("Do you want to remove your cart ? (press y): ");
            char comfirm = char.Parse(Console.ReadLine());
            if (comfirm == 'y' || comfirm == 'Y')
            {
                cart.products.RemoveRange(0,cart.products.Count);
            }
            //WriteJson();
            ReadJson();
        }
        public void PrintBill()
        {
            Console.Write("Do you want to print bill (press y): )");
            char comfirm = char.Parse(Console.ReadLine());
            if (comfirm == 'y' || comfirm == 'Y')
            {
                bill = new Cart()
                {
                    paid = true,
                    products = cart.products,
                    paymentTime = System.DateTime.Now
                };
                AfterPrintBill();
            }
            WriteJson();
            ReadJson();
            RemoveCart();
        }
        public void AfterPrintBill()
        {
            int pos = 0;
            foreach( var item in cart.products)
            {
                pos = CheckinWareHouse(item.name, item.qlt);
                wareHouse.inventories[pos].qlt -= item.qlt;
            }
        }
        public void AddEditProduct(string name, int qlt)
        {
            int posinWareHouse = CheckinWareHouse(name, qlt);
            int posinCart = CheckinCart(name);
            if (posinCart > -1)
            {
                cart.products[posinCart].qlt += qlt;
                if(cart.products[posinCart].qlt == 0)
                {
                    cart.products.RemoveAt(posinCart);
                }
                //else
                //{
                //    wareHouse.inventories[posinWareHouse].qlt -= qlt;
                //}
            }
            else
            {
                //name, wareHouse.inventories[posinWareHouse].price, qlt
                cart.products.Add(new Product(name, wareHouse.inventories[posinWareHouse].price, qlt)
                {
                });
                //wareHouse.inventories[posinWareHouse].qlt -= qlt;
            }
            WriteJson();
            ReadJson();
        }
        public int CheckinWareHouse(string name, int qlt)
        {
            for( int i = 0; i < wareHouse.inventories.Count; i++)
            {
                if (name == wareHouse.inventories[i].name && qlt <= wareHouse.inventories[i].qlt )
                {
                    return i;
                }
            }
            return -1;
        }
        public int CheckinCart(string name)
        {
            for (int i = 0; i < cart.products.Count; i++)
            {
                if (name == cart.products[i].name)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
