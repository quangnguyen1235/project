using System;
using employer;
class Employ
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
    }
    public static void Menu()
    {
        int option = 0;
        do
        {
            Console.WriteLine("1. Create employees");
            Console.WriteLine("2. Show employees");
            Console.WriteLine("3. Search employer");
            Console.WriteLine("4. Exit");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                option = number;
                
            }
            Process(option);
        } while (option != 4);
    }
    public static void Process(int opt)
    {
        switch (opt)
        {
            case 1:
                {
                    break;
                }
            case 2:
                {
                    break;
                }
            case 3:
                {
                    break;
                }
            case 4:
                {
                    break;
                }
        }
    }
}
