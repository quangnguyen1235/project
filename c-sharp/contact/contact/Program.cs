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
			Console.WriteLine("PhoneBook Management System");
			Console.WriteLine("----------------------------------");
			Console.WriteLine(" 1.Add Contact \n 2.Update Contact \n 3.Remove Contact \n 4.Search Contract \n 5.Show Contacts \n 6.Exit");
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
					Contact newContact = new Contact(name, phoneNumber);
					phonebook.Add(newContact);
					Console.Clear();
					break;
				}
			case 2:
				{
					Console.Write("Pls input name: ");
					name = Console.ReadLine();
					Console.Write("Pls input phonenumber: ");
					phoneNumber = Console.ReadLine();
					phonebook.Update(name,phoneNumber);
					Console.Clear();
					break;
				}
			case 3:
				{
					Console.Write("Pls input name to remove: ");
					name = Console.ReadLine();
					phonebook.Remove(name);
					Console.Clear();
					break;
				}
			case 4:
				{
					Console.Write("Pls input name to search: ");
					name = Console.ReadLine();
					phonebook.Search(name);
					Console.Clear();
					break;
				}
			case 5:
				{
					Console.WriteLine("----------------------------------");
					Console.WriteLine("This is contact list:");
					Console.WriteLine("----------------------------------");
					phonebook.ShowContact();
					Console.Clear();
					break;
				}
			case 6:
				{
					Environment.Exit(Environment.ExitCode);
					break;
				}
		}
		Menu(ref phonebook);
	}
}

/*
	Output: 2,3,4,5
*/
