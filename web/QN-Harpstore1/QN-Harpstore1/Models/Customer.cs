using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Models
{
    public class Customer
    {
        public string CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerAddress { get; set; }
        [Required]
        public string CustomerPhoneNumber { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        [Required]
        public string OrderId { get; set; }
        public Order CustomerOrder { get; set; }
    }
}
