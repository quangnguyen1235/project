using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Models
{
    public interface ICustomerRepository
    {
        Customer Get(string id);
        IEnumerable<Customer> Gets();
        bool Delete(string id);
        Customer Create(Customer customer);
        Customer Edit(Customer customer);
    }
}
