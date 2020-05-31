using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Bai3Exception
{
    class Account : IAcccount
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public float balance { get; private set; }
        public Account(int id, string firstName, string lastName, string gender)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
        }
        public void PayInto(float amount)
        {
            balance += amount;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {id}\t Name:{firstName} {lastName}\t Gender: {gender}\t Balance: {balance}");
        }
    }
}
