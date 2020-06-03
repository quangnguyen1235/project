using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    class Bank
    {
        private int Increment = 0;
        public Dictionary<int, Account> listAcount = new Dictionary<int, Account>();
        public void Main()
        {
			Menu();
        }
		public void Menu()
		{
			int option = 0;
			do
			{
				Console.WriteLine(Constants.MENU_START);
				Console.WriteLine(Constants.CREATE_ACCOUNT);
				Console.WriteLine(Constants.PAYINTO_ACCOUNT);
				Console.WriteLine(Constants.SHOW_INFO_ACCOUNT);
				Console.WriteLine(Constants.MENU_EXIT);
				Console.WriteLine(Constants.MENU_END);
				Console.Write(Constants.MENU_OPT);
				if (int.TryParse(Console.ReadLine(), out int number))
				{
					option = number;
				}
			}
			while (option < 1 || option > 4);
			Process(option);
		}
		public void Process(int opt)
		{
			Console.Clear();
			switch (opt)
			{
				case 1:
					{
                        CreateAccount();
                        break;
					}
				case 2:
					{
                        Payinto();
                        break;
					}
				case 3:
					{
						ShowInfo();
						break;
					}
				case 4:
					{
						Environment.Exit(Environment.ExitCode);
						break;
					}
			}
			Menu();
		}
        public void CreateAccount()
        {
            Account newAccount = Account.InputAccountInfomation(ref Increment);
            if (newAccount != null)
            {
                listAcount.Add(newAccount.id, newAccount);
            }
            else
            {
                Console.WriteLine("Invallid Account");
            }
        }
        public void Payinto()
        {
            string id = Helper.InputField(Constants.INPUT_ID, MyRegex.number, Constants.ERROR_UNFORMAT_ID);
            string amount = Helper.InputField(Constants.INPUT_AMOUNT, MyRegex.intnumber, Constants.ERROR_UNFORMAT_AMOUNT);
            if ( id != null && amount != null)
            {
                Account account = Check(int.Parse(id));
                float Amount = float.Parse(amount);
                if (account != null)
                {
                    try
                    {
                        if(-Amount > account.banlance)
                        {
                            throw new Exception(Constants.ERROR_NOT_ENOUGH_BALANCE);
                        }
                        account.PayInto(Amount);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Done");
                    }
                }
            } 
        }
        public void ShowInfo()
        {
			foreach (var item in listAcount.Values)
            {
				item.ShowInfo();
            }
        }
		private Account Check(int id)
        {
			foreach(var item in listAcount.Values)
            {
				if(item.id == id)
                {
					return item;
                }
            }
			return null;
        }
	}
}
