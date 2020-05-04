using System;
using System.Collections.Generic;
using contact;
public class Example
{
	public static void Main()
	{
		PhoneBook phonebook = new PhoneBook();
		
		Menu(ref phonebook);
	}
	public static void Menu(ref PhoneBook phonebook)
	{
		int option = 0;
		do
		{
			
			Console.WriteLine(" 1.Add Contact \n 2.Update Contact \n 3.Remove Contact \n 4.Search Contract \n 5.Soft \n 6.Exit");	
			Console.Write("Your option: ");
			if (int.TryParse(Console.ReadLine(), out int number))
			{
				option = number;
			}
			Process(option, ref phonebook);
		} while (option != 6);
			
	}
	public static void Process(int opt, ref PhoneBook phonebook)
	{
		Console.Clear();
		string name, phoneNumber;
		switch (opt)
		{
			case 1:
				{
					Console.Write("Pls input name: ");
					name = Console.ReadLine();
					Console.Write("Pls input phonenumber: ");
					phoneNumber = Console.ReadLine();
					phonebook.InsertPhone(name, phoneNumber);
					Console.ReadKey();
					break;
				}
			case 2:
				{
					Console.Write("Pls input name: ");
					name = Console.ReadLine();
					phonebook.UpdatePhone(name);
					Console.ReadKey();
					break;
				}
			case 3:
				{
					Console.Write("Pls input name to remove: ");
					name = Console.ReadLine();
					phonebook.RemovePhone(name);
					Console.ReadKey();
					break;
				}
			case 4:
				{
					Console.Write("Pls input name to search: ");
					name = Console.ReadLine();
					phonebook.SearchPhone(name);
					Console.ReadKey();
					break;
				}
			case 5:
				{

					phonebook.Sort(ref phonebook);
					for (int i = 0; i < phonebook.PhoneList.Length; i++)
					{
						Console.WriteLine(phonebook.PhoneList[i].ShowContact());
					}
					//Console.Clear();
					Console.ReadKey();
					break;
				}
				case 6:
				{
					Environment.Exit(Environment.ExitCode);
					break;
				}
		}
		Console.Clear();
		Menu(ref phonebook);
	}
}

/*
	Output: 2,3,4,5
*/
