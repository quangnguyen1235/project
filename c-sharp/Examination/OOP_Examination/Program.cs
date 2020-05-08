using System;
using System.Collections.Generic;

namespace OOP_Examination
{
    class Program
    {
		public static Forum<Post> ListofPost = new Forum<Post>();
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
				Console.WriteLine("1. Create Post.");
				Console.WriteLine("2. Update Post.");
				Console.WriteLine("3. Remove Post.");
				Console.WriteLine("4. Show Post.");
				Console.WriteLine("5. Exit.");
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
						CreatePost();
						break;
					}
				case 2:
					{
						UpdatePost();
						break;
					}
				case 3:
					{
						RemovePost();
						break;
					}
				case 4:
					{
						ShowPost();
						break;
					}
				case 5:
					{
						Environment.Exit(Environment.ExitCode);
						break;
					}
			}
			Menu();
		}
		public static void CreatePost()
		{
			Console.Write("Input Title:");
			string title = Console.ReadLine();
			Console.Write("Input Content: ");
			string content = Console.ReadLine();
			Console.Write("Input Author: ");
			string author = Console.ReadLine();
			int id = Increment;
			Increment++ ;
			Post post = new Post(id, title, content, author);
			for (int i = 0; i <post.Rates.Length; i++)
			{
				Console.Write($"Rate {i + 1}: ");
				post.Rates[i] = int.Parse(Console.ReadLine());
			}
			ListofPost.Add(post.ID, post);
		}
		public static void UpdatePost()
		{
			Console.Write("Input ID to update: ");
			int idUpdate = int.Parse(Console.ReadLine());
			Console.Write("Input New Content: ");
			string newContent = Console.ReadLine();
			ListofPost.Update(idUpdate, newContent);
		}
		public static void RemovePost()
		{
			Console.Write("Input ID to Remove: ");
			int idRemove = int.Parse(Console.ReadLine());
			ListofPost.Remove(idRemove);
		}
		public static void ShowPost()
		{
			ListofPost.Show();
		}
	}
}
