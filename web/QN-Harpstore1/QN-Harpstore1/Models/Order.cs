using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime DeliveryDate { get; set; }
        [Required]
        public float OrderTotalMoney { get; set; }
        [Required]
        public string OrderDetailId { get; set; }
        public ICollection<OrderDetail> ListOrderDetails { get; set; }
        [Required]
        public string CustomerId { get; set; }
        public Customer OrderCustomer { get; set; }
    }
}
