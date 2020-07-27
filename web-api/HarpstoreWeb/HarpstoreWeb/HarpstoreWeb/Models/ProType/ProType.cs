using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarpstoreWeb.Models.ProType
{
    public class ProType
    {
        public int ProTypeId { get; set; }
        public string ProTypeName { get; set; }
        public int Products { get; set; }
    }
}
