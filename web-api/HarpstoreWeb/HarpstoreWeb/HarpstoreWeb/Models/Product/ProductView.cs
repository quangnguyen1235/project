using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarpstoreWeb.Models.Product
{
    public class ProductView
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string AvataPath { get; set; }
        public string ProducerName { get; set; }
        public string ProTypeName { get; set; }
        public float ProductPrice { get; set; }
    }
}
