using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext context;

        public CustomerRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Customer Create(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return customer;
        }

        public bool Delete(string id)
        {
            var delCustomer = context.Customers.Find(id);
            if (delCustomer != null)
            {
                context.Customers.Remove(delCustomer);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public Customer Edit(Customer customer)
        {
            var editOrder = context.Customers.Attach(customer);
            editOrder.State = EntityState.Modified;
            context.SaveChanges();
            return customer;
        }

        public Customer Get(string id)
        {
            return context.Customers.Find(id);
        }

        public IEnumerable<Customer> Gets()
        {
            return context.Customers;
        }
    }
}
