using System;
using System.Collections.Generic;
using System.Text;

namespace Colections_Contact
{
    public class Contact
    {
        private string _phoneNumber;
        private string _name;
        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public Contact (string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return $"Name: {Name}\t PhoneNumber: {PhoneNumber}";
        }

        public static explicit operator Contact(int v)
        {
            throw new NotImplementedException();
        }
    }
}
