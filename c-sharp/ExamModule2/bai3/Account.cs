using System;
using System.Collections.Generic;
using System.Text;

namespace bai3
{
    class Account : IAcount
    {
        public int AccountID { get; set; }
        public string Fristname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public float Balance { get; private set; }
        public Account(int id, string firstName, string lastName, string gender)
        {
            AccountID = id;
            Fristname = firstName;
            Lastname = lastName;
            Gender = gender;
        }
        public void PayInto(float amount)
        {
            Balance += amount;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {AccountID}\t First name: {Fristname}\t Last name: {Lastname}\t Gender: {Gender}\t Balance: {Balance}");
        }
    }
}
