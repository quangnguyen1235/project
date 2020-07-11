using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Models
{
    public class OrderDetail
    {
        public string OrderDetailId { get; set; }
        [Required]
        public string ProductId { get; set; }
        public Product OrderDetailProduct { get; set; }
        [Required]
        public float OrderDetailMoney { get; set; }
        [Required]
        public int OrderDetailQlt { get; set; }
        [Required]
        public string OrderId { get; set; }
        public Order OrderDetailOrder { get; set; }
    }
}
