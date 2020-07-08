using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class SqlEmployeeRepository : IEmployeeReponsitory
    {
        private readonly AppDbContext appDbContext;

        public SqlEmployeeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public Employee Create(Employee employee)
        {
            appDbContext.Employees.Add(employee);
            appDbContext.SaveChanges();
            return employee;
        }

        public bool Delete(int id)
        {
            var delEmp = appDbContext.Employees.Find(id);
            if (delEmp != null)
            {
                appDbContext.Employees.Remove(delEmp);
                return appDbContext.SaveChanges() > 0;
            }
            return false;
        }

        public Employee Edit(Employee employee)
        {
            var editEmp = appDbContext.Employees.Attach(employee);
            editEmp.State = EntityState.Modified;
            appDbContext.SaveChanges();
            return employee;
        }

        public Employee Get(int id)
        {
            return appDbContext.Employees.Find(id);
        }

        public IEnumerable<Employee> Gets()
        {
            return appDbContext.Employees;
        }
    }
}
