using System;
using System.Collections.Generic;
using System.Text;

namespace contact
{
    abstract public class Phone
    {
        abstract public void InsertPhone(string name, string PhoneNumber);
        abstract public void RemovePhone(string name);
        abstract public void UpdatePhone(string name);
        abstract public void SearchPhone(string name);
        abstract public void Sort(ref PhoneBook phoneBook);
    }
}
