using FinalModul2;
using System;

namespace Cau2
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
				Console.WriteLine("2. Check IsIncreaseArray");
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
						string n = Helper.InputField(Constants.INPUT_Number, MyRegex.number, Constants.ERROR_UNFORMAT_ID);
						if (n != null)
                        {
							array.CreateArray(int.Parse(n));
							Console.WriteLine(array.ToString());
						}
						break;
					}
				case 2:
					{
                        if(array.arr == null)
                        {
							Console.WriteLine("Invallid!");
                        }
                        else
                        {
							if (array.CheckArr())
							{
								Console.WriteLine("Increase!");
							}
							else
							{
								Console.WriteLine("Not Increase");
							}
						}
						break;
                    }
				case 3:
					{
						if (array.arr == null)
						{
							Console.WriteLine("Invallid!");
						}
						else
						{
							array.SelectionSort();
							Console.WriteLine(array.ToString());
						}
						break;
					}
				case 4:
					{

						if (array.arr == null)
						{
							Console.WriteLine("Invallid!");
						}
						else
						{
							if (array.CheckArr())
							{
								string found = Helper.InputField(Constants.INPUT_Number, MyRegex.number, Constants.ERROR_UNFORMAT_ID);
								if (found != null)
								{
									var pos = array.Find(int.Parse(found), 0, array.arr.Length - 1);

									if (pos > -1)
									{
										Console.WriteLine($"{found} at {pos} in array");
									}
									else
									{
										Console.WriteLine(Constants.ERROR_ACCOUNT_NOT_EXIST);
									}

								}
								else
								{
									Console.WriteLine("The array need to sort first");
								}
							}
						}
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
