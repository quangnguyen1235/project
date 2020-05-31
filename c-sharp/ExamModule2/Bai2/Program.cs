using System;

namespace Bai2
{
    class Program
    {
		public static Arr array = new Arr()
		{

		};
        static void Main(string[] args)
        {
			Menu();
        }
		public static void Menu()
		{
			int option = 0;
			do
			{
				Console.WriteLine("1. Create Arr");
				Console.WriteLine("2. Check Symmetry");
				Console.WriteLine("3. Sort Arr");
				Console.WriteLine("4. Find");
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
						array.CreateArray(5);
						break;
					}
				case 2:
					{
						string v = array.Isincrement().ToString();
						Console.WriteLine("ISINC" + v);
						break;
					}
				case 3:
					{
						array.BubbleSort();
						Console.WriteLine(array.ToString());
						break;
					}
				case 4:
					{
						//if (array.Isincrement())
						//{
							array.BubbleSort();
							Console.Write("input number to find: ");
							int found = int.Parse(Console.ReadLine());
							Console.WriteLine($"{found} at {array.Find(found, 0, array.arr.Length - 1)} in array");
						//}
						//else
						//{
						//	Console.WriteLine("The array need to sort first");
						//}
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
	
        
    }
}
