using System;
using System.Collections.Generic;
using System.Text;

namespace Colections_Contact
{
    abstract public class Phone
    {
        public abstract void InsertPhoneNumber(string name, string phoneNumber);
        public abstract void RemovePhoneNumber(string name);
        public abstract void UpdatePhoneNumber(string name);
        public abstract void SearchPhoneNumber(string name);
        public abstract void SoftPhoneNumber();
    }
}
