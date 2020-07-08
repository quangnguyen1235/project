using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private List<Employee> employees;
        public EmployeeRepository()
        {
            employees = new List<Employee>()
            {
                new Employee(1,"Nguyến Đăng Quang", "it", "~/images/asdsad.png"),
                new Employee(2,"Tôn Thất Anh Minh", "it", "~/images/asdsad.png"),
                new Employee(3,"Hà Văn Tín", "it", "~/images/asdsad.pngs")
            };
        }
        public IEnumerable<Employee> Gets()
        {
            return employees;
        }
        public Employee Get(int id)
        {
            return employees.FirstOrDefault(e => e.id == id);
        }

    }
}
