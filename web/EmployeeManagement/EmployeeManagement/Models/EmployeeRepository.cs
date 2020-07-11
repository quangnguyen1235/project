using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class EmployeeRepository : IEmployeeReponsitory
    {
        private List<Employee> employees;
        public EmployeeRepository()
        {
            employees = new List<Employee>()
            {
                new Employee() { Id = 1, fullName = "Nguyễn Đăng Quang", email = "nguyendangquanghbt12b7@gmail.com", ava = "~/images/unknownPerson.jpg", departerment = Dept.IT },
                new Employee() { Id = 2, fullName = "Tôn Thất Anh Minh", email = "minhminh.codegym@gmail.com", ava = "~/images/unknownPerson.jpg", departerment = Dept.Payroll },
                new Employee() { Id = 3, fullName = "Nguyễn Xuân Trung", email = "xuantrung.nguyen@gmail.com", ava = "~/images/unknownPerson.jpg", departerment = Dept.IT },
                //new Employee(2, "Tôn Thất Anh Minh", "minhminh.codegym@gmail.com", "~/images/unknownPerson.jpg", Dept.Payroll),
                //new Employee(3, "Hà Văn Tín", "tin.ha@gmail.com", "~/images/unknownPerson.jpg", Dept.HR)
            };
        }

        public Employee Create(Employee employee)
        {
            employee.Id = employees.Max(e => e.Id) + 1;
            employee.ava = "~/images/unknownPerson.jpg";
            employees.Add(employee);
            return employee;
        }

        public bool Delete(int id)
        {
            var delEmp = Get(id);
            if(delEmp != null)
            {
                employees.Remove(delEmp);
                return true;
            }
            return false;
        }

        public Employee Edit(Employee employee)
        {
            var emp = Get(employee.Id);
            emp.fullName = employee.fullName;
            emp.email = employee.email;
            emp.departerment = employee.departerment;
            return emp;
        }

        public Employee Get(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);#if
        }

        public IEnumerable<Employee> Gets()
        {
            return employees;
        }
    }
}
