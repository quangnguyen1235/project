using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.ViewModels
{
    public class HomeEditViewModel : HomeCreateViewModel
    {
        public int id { get; set; }
        public string AvaPath { get; set; }

    }
}
