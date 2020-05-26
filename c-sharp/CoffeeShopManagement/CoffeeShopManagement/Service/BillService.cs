using CoffeeShopManagement.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace CoffeeShopManagement.Service
{
    class BillService
    {
        private string dataPath = @"";
        private string billPath = @"";
        private Data orderData = new Data()
        {
            orders = new List<Oder>()
        };

        public BillService (string dataPath)
        {
            this.dataPath = dataPath;
        }
        public void ReadData()
        {
            using (StreamReader sr = File.OpenText(dataPath))
            {
                var obj = sr.ReadToEnd();
                orderData = JsonConvert.DeserializeObject<Data>(obj);
            }
        }
        public void WriteData()
        {
            using (StreamWriter sw = File.CreateText(dataPath))
            {
                var data = JsonConvert.SerializeObject(orderData);
                sw.Write(data);
            }
        }
        public void AddOrder(int tableNo, OrderDetails newItem)
        {
            orderData.orders.Add(new Oder(tableNo,newItem));
            WriteData();
        }
        public void UpdateOrder(int tableNo, string foodName, int price, int qlt)
        {
            var pos = checkTable(tableNo);
            var newItem = new OrderDetails(foodName, price, qlt);
            if (pos > -1)
            {
                for(int i = 0; i < orderData.orders.Count; i++)
                {
                    orderData.orders[i].orderDetails.Add(newItem);
                }
                WriteData();
            }
            else
            {
                AddOrder(tableNo, newItem);
            }
        }
        public void 
        private int checkTable(int tableNo)
        {
            for(int i = 0; i < orderData.orders.Count; i++)
            {
                if (orderData.orders[i].tableNo == tableNo && orderData.orders[i].paid)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
