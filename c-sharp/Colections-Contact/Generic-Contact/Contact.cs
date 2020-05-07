using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Contact
{
    public class Contact
    {
        private string name;
        private string phoneNumber;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }
        public Contact(string Name, string PhoneNumber)
        {
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
        }
        public override string ToString()
        {
            return $"Name: {Name}\t PhoneNumber: {PhoneNumber}";
        }
    }
}
