using BeerStore.Modals;
using BeerStore.Service;
using System;

namespace BeerStore
{
    class Program
    {
        public static string database = @"C:\Users\Admin\Documents\project\project\c-sharp\BeerStore\BeerStore\Database\WareHouse.json";
        public static string outputBill = $@"C:\Users\Admin\Documents\project\project\c-sharp\BeerStore\BeerStore\Bill\Bill{DateTime.Now.ToString("dd_MM_yyyy hh_mm_ss tt")}.json";
        public static JsonService js = new JsonService(database, outputBill);
        static void Main(string[] args)
        {
			Menu();
        }
		public static void Menu()
		{
			js.ReadJson();
			int option = 0;
			do
			{
				js.Menu();
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
						string name = Helper.Helper.inputName();
						int qlt = Helper.Helper.inputQlt();
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
						js.RemoveCart();
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
			js.ReadJson();
		}
	}
}
