using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.ViewModels
{
    public class HomeEditViewModel : HomeCreateViewModel
    {
        public string id { get; set; }
        public string avaPath { get; set; }
        public string ProductProducerName { get; set; }
        public string ProductTypeName { get; set; }
    }
}
