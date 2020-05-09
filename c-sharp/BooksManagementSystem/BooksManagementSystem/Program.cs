using System;
using System.Collections.Generic;
using System.Net;

namespace BooksManagementSystem
{
    class Program
    {
		public static Dictionary<int, Book> ListofBook = new Dictionary<int, Book>();
		public static int Increment = 1;
        static void Main(string[] args)
        {
			Menu();
        }
		public static void Menu()
		{
			int option = 0;
			do
			{
				Console.WriteLine("1. Insert new book.");
				Console.WriteLine("2. View list of books.");
				Console.WriteLine("3. Average price.");
				Console.WriteLine("4. Exit.");
				Console.WriteLine();
				Console.Write("Your option: ");
				if (int.TryParse(Console.ReadLine(), out int number))
				{
					option = number;
				}
			}
			while (option < 1 || option > 5);
			Process(option);
		}
		public static void Process(int opt)
		{
			Console.Clear();
			switch (opt)
			{
				case 1:
					{
						InsertNewBook();
						break;
					}
				case 2:
					{
						ViewListofBooks();
						break;
					}
				case 3:
					{
						CalculateAverage();
						ViewListofBooks();
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
		public static void InsertNewBook()
		{
			Console.Write("Please input Name of book: ");
			string name = Console.ReadLine();
			DateTime publishDate = DateTime.Now;
			Console.Write("Please input Author: ");
			string author = Console.ReadLine();
			Console.Write("Please input Language: ");
			string language = Console.ReadLine();
			int id = Increment;
			Increment++;
			Book newbook = new Book(id, name, publishDate, author, language);
			for(int i = 0; i < newbook.PriceList.Length; i++)
			{
				Console.Write($"Input price {i+1}: ");
				newbook.PriceList[i] = int.Parse(Console.ReadLine());
			}
			ListofBook.Add(newbook.ID, newbook);
		}
		public static void ViewListofBooks()
		{
			foreach(KeyValuePair<int, Book> book in ListofBook)
			{
				book.Value.DisPlay();
			}
		}
		public static void CalculateAverage()
		{
			foreach(KeyValuePair<int, Book> book in ListofBook)
			{
				book.Value.CalculatorAveragePrice();
			}
		}
	}
}
