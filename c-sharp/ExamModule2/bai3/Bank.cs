using System;
using System.Collections.Generic;
using System.Text;

namespace bai3
{
    class Bank
    {
		static int Increment = 0;
		public Dictionary<int, Account> listAccout = new Dictionary<int, Account>();


		public void Main()
		{
			Menu();
		}
		public void Menu()
		{
			int option = 0;
			do
			{
				Console.WriteLine("1. Create Account");
				Console.WriteLine("2. Pay Into");
				Console.WriteLine("3. Show Customer Data");
				Console.WriteLine("4. Exit.");
				Console.WriteLine();
				Console.Write("Your option: ");
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
						int id = Increment;
						Console.Write("Intput first name: ");
						string name = Console.ReadLine();
						Console.Write("Input last name: ");
						string lastName = Console.ReadLine();
						Console.Write("Intput gender: ");
						string gender = Console.ReadLine();
						CreateAccount(id, name, lastName, gender);
						Increment++;
						break;
					}
				case 2:
					{
						Console.Write("Intput id: ");
						int id = int.Parse(Console.ReadLine());
						if (Check(id) == -1)
						{
							Console.WriteLine("Invalid account");
						}
						else
						{
							try
							{
								Console.Write("Intput amount: ");
								float balance = float.Parse(Console.ReadLine());
								PayInto(id, balance);
							}
							catch (Exception e)
							{
								Console.WriteLine("Something Wrong");
							}
							finally
							{
								Console.WriteLine("done");
							}
						}
						break;
					}
				case 3:
					{
						showData();
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
		public void CreateAccount(int id, string firstName, string lastName, string gender)
		{
			Account newAccount = new Account(id, firstName, lastName, gender);
			listAccout.Add(newAccount.AccountID, newAccount);

		}
		public void PayInto(int id, float amount)
		{
			int pos = Check(id);
			if (pos > -1)
			{
				listAccout[pos].PayInto(amount);
			}
			else
			{
				Console.WriteLine("Invallid Account");
			}
		}
		public int Check(int id)
		{
			for(int i = 0; i < listAccout.Count; i++)
			{
				if(listAccout[i].AccountID == id)
				{
					return i;
				}
			}
			return -1;
		}
		public void showData()
		{
			for(int i = 0; i < listAccout.Count; i++)
			{
				listAccout[i].ShowInfo();
			}
		}
	}
}
