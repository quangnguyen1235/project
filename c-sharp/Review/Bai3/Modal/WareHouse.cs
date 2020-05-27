using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.Modal
{
    class WareHouse
    {
        public List<Inventory> inventories { get; set; }
        public Inventory Find(int? id, string? name)
        {
            foreach (var item in inventories)
            {
                if(item.id == id || item.name == name)
                {
                    return item;
                }
            }
            return null;
        }
        public void AddIventory(int id, string name, int price, int remain)
        {
            inventories.Add(new Inventory(id, name, price, remain));
        }
    }
}
