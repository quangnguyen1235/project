using System;
using System.Collections.Generic;
using System.Text;

namespace contact
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
        public Contact(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }
        public string ShowContact()
        {
            return $"Name: {Name}\t Phonenumber: {PhoneNumber}";
        }
    }
}
