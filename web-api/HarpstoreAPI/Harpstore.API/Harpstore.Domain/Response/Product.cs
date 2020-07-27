using System;
using System.Collections.Generic;
using System.Text;

namespace Harpstore.Domain.Response
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string AvataPath { get; set; }
        public int ProducerId { get; set; }
        public int ProTypeId { get; set; }
        public float ProductPrice { get; set; }
    }
}
