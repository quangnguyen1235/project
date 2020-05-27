using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Bai3.Modal
{
    class Customer
    {
        public string name { get; set; }
        public string address { get; set; }
        public Customer(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public override string ToString()
        {
            return $"Name: {name}\t Address: {address}";
        }
    }
}
