using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.Modal
{
    class Order
    {
        public int id { get; set; }
        public bool paid { get; set; }
        public int total => calculatTotal();
        public Customer customer { get; set; }
        public List<Product> products { get; set; }
        public Order(int id, string paid, Customer customer, List<Product> products)
        {
            this.id = id;
            this.paid = bool.Parse(paid);
            this.customer = customer;
            this.products = products; 
        }
        public bool ChangeStatus(string status)
        {
            return paid = bool.Parse(status);
        }
        public int calculatTotal()
        {
            int total = 0;
            foreach (var item in products)
            {
                total += item.money;
            }
            return total;
        }
        public override string ToString()
        {
            return $"\n ID: {id}\t Paid: {paid}\n {customer.ToString()}\n {ShowProducts()} \n Total: {total}";
        }
        public string ShowProducts()
        {
            string result = "";
            foreach(var item in products)
            {
                result += $"\n {item.ToString()}"  ;
            }
            return result;
        }
        public void EditCustommer(string name, string address)
        {
            customer.name = name;
            customer.address = address;
        }
        public void AddEditProduct(int id, int qlt)
        {
            Product product = CheckProduct(id);
            if (product != null)
            {
                product.qlt += qlt;
            }
            else
            {
                products.Add(product);
            }
        }
        private Product CheckProduct(int id)
        {
            foreach(var item in products)
            {
                if (item.id == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
