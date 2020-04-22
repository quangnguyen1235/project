using System;

namespace OOP
{
    class Student
    {
        private string fullName;

        private string email;

        private string phoneNumber;

        public string Email {
            get {
                return email;
            }
            set {
                email = value;
            }
        }
        public string PhoneNumber 
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }
    }
}