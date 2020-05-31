using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Bai3Exception
{
    class Bank
    {
		public static int Increment = 0;
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
						CreateAccount();
						break;
					}
				case 2:
					{
						PayInto();
						break;
					}
				case 3:
					{
						ShowList();
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
			int id = Increment;
			Console.Write("Input firstName: ");
			string firstName = Console.ReadLine();
			Console.Write("Input lastName: ");
			string lastName = Console.ReadLine();
			Console.Write("Input Gender: ");
			string gender = Console.ReadLine().ToLower();
			try
			{
				if (gender != "male" && gender != "female")
				{
					throw new Exception("Ivallid gender fomat");
				}
				listAcount.Add(id,new Account(id, firstName, lastName, gender));
				Increment++;
			}
			catch (Exception mexp)
			{
				Console.WriteLine(mexp.Message);
			}
			finally
			{
				Console.WriteLine("Done!");
			}
		}
		public void ShowList()
		{
			foreach(var item in listAcount.Values)
			{
				item.ShowInfo();
			}
		}
		public void PayInto()
		{
			try
			{
				Console.WriteLine("Input customer Id: ");
				int id = int.Parse(Console.ReadLine());
				Console.WriteLine("Input customer Amount: ");
				float amount = float.Parse(Console.ReadLine());
				if (checkCustomer(id) == null)
				{
					throw new Exception("Ivallid ID");
				}
				checkCustomer(id).PayInto(amount);
			}
			catch(FormatException fex)
			{
				Console.WriteLine(fex.Message);
			}
			catch(Exception me)
			{
				Console.WriteLine(me.Message);
			}
			finally
			{
				Console.WriteLine("Done!");
			}
		}
		private Account checkCustomer(int id)
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
