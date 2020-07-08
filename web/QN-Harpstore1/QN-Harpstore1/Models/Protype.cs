using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Models
{
    public class Protype
    {
        public int ProTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public ICollection<Product> ListProducts { get; set; }
    }
}
