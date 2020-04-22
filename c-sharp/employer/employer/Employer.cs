using System;
using System.Collections.Generic;
using System.Text;

namespace employer
{
    class Employer
    {
        private string name;
        private string email;
        private string address;
        private DateTime dob;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Address
        {
            get => address;
            set => address = value;
        }
        public DateTime Dob
        {
            get => dob;
            set => dob = value;
        }
        Employer[] employees = new Employer[0];
        public int GetAge()
        {
            return DateTime.Now.Year - dob.Year;
        }
        //public void ShowInfo()
        //{
        //    Console.WriteLine($"Name: {name}\t Email: {email}\t Address: {address}\t DOB: {dob}\t Age: {GetAge()}");
        //}
        public void CreateEmployees(Employer newEpm)
        {
            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = newEpm;
            Console.WriteLine("Done!");
        }
        public void ShowEmployees()
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Name: {employees[i].Name}\t Email: {employees[i].Email}\t Address: {employees[i].Dob}\t Age: {GetAge()}");
            }
        }
    }
}
