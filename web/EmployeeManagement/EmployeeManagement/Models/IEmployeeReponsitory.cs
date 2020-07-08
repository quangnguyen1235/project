using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Reflection;
using System.Reflection.Metadata;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace EmployeeManagement.Models
{
    public interface IEmployeeReponsitory
    {
        IEnumerable<Employee> Gets();
        Employee Get(int id);
        Employee Create(Employee employee);
        Employee Edit(Employee employee);
        bool Delete(int id);

    }
}
