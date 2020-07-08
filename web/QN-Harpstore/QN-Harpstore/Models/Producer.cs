using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore.Models
{
    //public enum Producer
    //{
    //    Easttop,
    //    Suzuki,
    //    Tombo,
    //    Hohner,
    //    Seydel
    //}
    public class Producer
    {
        public int ProducerId { get; set; }
        public string ProducerName { get; set; }
        public ICollection<Product> ListProducts { get; set; }
    }
}
