using System;
using BeerStore2.Modal;
using BeerStore2.Service;

namespace BeerStore2
{
    class Program
    {
        public static string database = @"C:\Users\Admin\Documents\project\project\c-sharp\BeerStore2\BeerStore2\Database\Inventories.json";
        public static string outputBill = $@"C:\Users\Admin\Documents\project\project\c-sharp\BeerStore2\BeerStore2\Bill\bill_{DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss_tt")}.json";
        public static JsonService js = new JsonService(database, outputBill);
        static void Main(string[] args)
        {
			Menu();
        }
		public static void Menu()
		{
			js.ReadDatabase();
			int option = 0;
			do
			{
				//js.Menu();
				Console.WriteLine("1. Edit Cart");
				Console.WriteLine("2. Show your cart");
				Console.WriteLine("3. Remove cart");
				Console.WriteLine("4. Print bill");
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
						Console.Write("Input product name: ");
						string name = Console.ReadLine();
						Console.Write("Input Qlt: ");
						int qlt = int.Parse(Console.ReadLine());
						js.AddEditProduct(name, qlt);
						break;
					}
				case 2:
					{
						js.ShowCart();
						break;
					}
				case 3:
					{
						Console.WriteLine("Do you want remove your cart? ");
						Console.Write($"Press 'y' to confirm: ");
						char character = char.Parse(Console.ReadLine().ToLower());
						if (character.Equals('y'))
						{
							js.RemoveCart();
						}
						break;
					}
				case 4:
					{
						js.PrintBill();
						break;
					}
				case 5:
					{
						Environment.Exit(Environment.ExitCode);
						break;
					}
			}
			Menu();
			//js.ReadJson();
		}
	}
}
