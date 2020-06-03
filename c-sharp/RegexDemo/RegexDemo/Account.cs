using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    class Account:IAccount
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public float banlance { get; private set; }
        public Account(int id, string firstName, string lastName, string gender)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
        }
        public void PayInto(float Amount)
        {
            banlance += Amount;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {id}\t" +
                              $"Name: {firstName} {lastName}\t" +
                              $"Gender: {gender}\t " +
                              $"Balance: {banlance}");
        }
        static public Account InputAccountInfomation(ref int id)
        {
            string firstName = Helper.InputField(Constants.INPUT_FIRST_NAME, MyRegex.name, Constants.ERROR_INVALLID_NAME);
            string lastName = Helper.InputField(Constants.INPUT_FIRST_NAME, MyRegex.name, Constants.ERROR_INVALLID_NAME);
            string gender = Helper.InputField(Constants.INPUT_GENDER, MyRegex.gender, Constants.ERROR_INVALLID_GENDER);
            if (firstName != null && lastName != null && gender != null)
            {
                Account account = new Account(id, firstName, lastName, gender);
                id++;
                return account;
            }
            return null;
        }
    }
}
