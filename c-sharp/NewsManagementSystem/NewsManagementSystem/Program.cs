using System;
using System.Collections;

namespace NewsManagementSystem
{
    class Program
    {
		static public Hashtable ListNews = new Hashtable();
		static int Increment = 1;

		static void Main(string[] args)
        {
			Menu();
        }
		public static void Menu()
		{
			int option = 0;
			do
			{

				Console.WriteLine(" 1.Insert news \n 2.Wiew list news \n 3.Avenrange rate \n 4.Exit");
				Console.Write("Your option: ");
				if (int.TryParse(Console.ReadLine(), out int number))
				{
					option = number;
				}
				Process(option);
			} while (option != 6);

		}
		public static void Process(int opt)
		{
			Console.Clear();
			switch (opt)
			{
				case 1:
					{
						InsertNews();
						break;
					}
				case 2:
					{
						WiewList();
						break;
					}
				case 3:
					{
						CalculateAve();
						WiewList();
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
		static public void InsertNews()
		{
			News news = new News();
			Console.Write("Title: ");
			string title = Console.ReadLine();
			DateTime puslishDate = DateTime.Now;
			Console.Write("Author: ");
			string author = Console.ReadLine();
			Console.Write("Content: ");
			string content = Console.ReadLine();
			Console.WriteLine("Enter rate: ");
			for(int i = 0; i < news.RateList.Length; i++)
			{
				Console.Write($"Rate {i + 1}: ");
				news.RateList[i] = int.Parse(Console.ReadLine());
			}
			news.Title = title;
			news.PublishDate = puslishDate;
			news.Author = author;
			news.Content = content;
			news.ID = Increment;
			Increment++;
			ListNews.Add(news.ID, news);
		}
		public static void WiewList()
		{
			foreach (News news in ListNews.Values)
			{
				news.Display();
			}
		}
		public static void CalculateAve()
		{
			foreach (News news in ListNews.Values)
			{
				news.Calculate();
			}
		}
	}
}
