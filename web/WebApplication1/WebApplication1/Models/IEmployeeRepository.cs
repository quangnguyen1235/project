using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    interface IEmployeeRepository
    {
        IEnumerable<Employee> Gets();
        Employee Get(int id);
    }
}
