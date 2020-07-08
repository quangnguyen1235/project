using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.ViewModels
{
    public class ProductDetailViewModel
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string ProductAvatar { get; set; }
        public int ProductTypeId { get; set; }
        public int ProducerId { get; set; }
        public bool IsUsed { get; set; }
        public float ProductPrice { get; set; }
        public string ProductProducerName { get; set; }
        public string ProductTypeName { get; set; }
    }
}
