using System;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    class Program
    {
        public static Bank newBank = new Bank();
        public static string inOutPut = @"C:\Users\Admin\Documents\project\project\c-sharp\RegexDemo\RegexDemo\Database\db.json";
        static void Main(string[] args)
        {
            BankService bankService = new BankService(inOutPut);
            bankService.ReadJson();
            //newBank.Main();
            //Regex regex = new Regex("^male$|^female$");
            //Match match = regex.Match("Male");
            //Console.WriteLine(match.Success);
            //string name = Helper.InputField(Constants.INPUT_FIRST_NAME, MyRegex.name, Constants.ERROR_INVALLID_NAME);
            //string id = Helper.InputField(Constants.INPUT_ID, MyRegex.number, Constants.ERROR_UNFORMAT_ID);
            //int.Parse(id);
            //string firstName = Helper.InputField(Constants.INPUT_FIRST_NAME, MyRegex.name, Constants.ERROR_INVALLID_NAME);
            //string lastName = Helper.InputField(Constants.INPUT_LAST_NAME, MyRegex.name, Constants.ERROR_INVALLID_NAME);
            //string gender = Helper.InputField(Constants.INPUT_GENDER, MyRegex.gender, Constants.ERROR_INVALLID_GENDER);
            //if (firstName == null || lastName == null || gender == null)
            //{
            //    Console.WriteLine("invallid");
            //}

        }
    }
}
