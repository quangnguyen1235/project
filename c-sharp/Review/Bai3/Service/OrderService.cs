using Bai3.Modal;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Transactions;

namespace Bai3.Service
{
    class OrderService
    {
        public OrderData orderData;
        public string input { get; set; }
        public string output { get; set; }
        public OrderService(string input, string output)
        {
            this.input = input;
            this.output = output;
            orderData = new OrderData()
            {
                orders = new List<Order>()
            };
        }
        public void ReadOderData()
        {
            using (StreamReader sr = File.OpenText(input))
            {
                var obj = sr.ReadToEnd();
                orderData = JsonConvert.DeserializeObject<OrderData>(obj);
            }
        }
        public void WriteOderData()
        {
            using (StreamWriter sw = File.CreateText(output))
            {
                var data = JsonConvert.SerializeObject(orderData);
                sw.Write(data);
            }
        }
        public void CreateOrder(int id, string paid, Customer customer, List<Product> products)
        {
            orderData.orders.Add(new Order(id, paid, customer, products));
        }
        public void ShowOrder()
        {
            foreach (var item in orderData.orders)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public Order CheckOrder(int id)
        {
            foreach (var item in orderData.orders)
            {
                if (item.id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public void EditOrder(int id, int opt)
        {
            Order order = CheckOrder(id);
            switch (opt)
            {
                case 1:
                    {
                        Console.Write("Input NewCustomer Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Input NewCustomer Address: ");
                        string address = Console.ReadLine();
                        EditCustomer(name, address, order);
                        break;
                    }
                case 2:
                    {
                        Console.Write("input Product id: ");
                        int proId = int.Parse(Console.ReadLine());
                        Console.Write("input qlt: ");
                        int qlt = int.Parse(Console.ReadLine());
                        AddEditProduct(proId, qlt, order);
                        break;
                    }
            }
        }
        public void EditCustomer(string name, string address, Order order)
        {
            order.EditCustommer(name, address);
            WriteOderData();
        }
        public void AddEditProduct(int id, int qlt, Order order)
        {
            order.AddEditProduct(id, qlt);
            WriteOderData();
        }
        public void SearchOrder(int id)
        {
            Console.WriteLine(CheckOrder(id).ToString());
        }
        public void SearchOrder(string name, string address)
        {
            orderData.FindByCustomer(name, address);
        }
    }
}
