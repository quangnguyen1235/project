using System;

namespace ProductManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();
        }
        public static void Init()
        {
            Shop productList = new Shop();
            Menu(ref productList);
        }
        public static void Menu(ref Shop productList)
        {
            int option = 0;
            do
            {
                Console.WriteLine("1. Add new product");
                Console.WriteLine("2. Remove product");
                Console.WriteLine("3. Interate product");
                Console.WriteLine("4. Search product");
                Console.WriteLine("5. Exit");
                Console.Write("Your option is: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }
                Process(option, ref productList);
            } while (option != 5);
        }
        public static void Process(int opt, ref Shop productList)
        {
            double[] rate;
            string name;
            string description;
            double price;
            switch (opt)
            {
                case 1:
                    {
                        Console.Write("Please Enter how many products: ");
                        int amount = int.Parse(Console.ReadLine());
                        for(int i = 0; i < amount; i++)
                        {
                            Products product = new Products();
                            Console.Write("Please input Name: ");
                            product.Name = Console.ReadLine();
                            Console.Write("Please input Description: ");
                            product.Description = Console.ReadLine();
                            Console.Write("Please input Price: ");
                            product.Price = double.Parse(Console.ReadLine());
                            product.Rate = product.setRate();
                            productList.AddProduct(product);
                        }
                        break;
                    }
                case 2:
                    {
                        Console.Write("Pls input name to remove: ");
                        name = Console.ReadLine();
                        productList.RemoveProduct(name);
                        Console.Clear();
                        break;
                    }
                case 3:
                    {
                        productList.IterateProductList();
                        break;
                    }
                case 4:
                    {
                        Console.Write("Pls min price to search: ");
                        double minPrice = double.Parse(Console.ReadLine());
                        Console.Write("Pls max price to search: ");
                        double maxPrice = double.Parse(Console.ReadLine());
                        name = Console.ReadLine();
                        productList.SearchProduct(minPrice, maxPrice );
                        break;
                    }
                case 5:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
        }
        //static public double[] setRate()
        //{
        //    Console.Write("Pls Enter how many vote: ");
        //    int amount = int.Parse(Console.ReadLine());
        //    double[] rate = new double[0];
        //    for (int i = 0; i < amount; i++)
        //    {
        //        Array.Resize(ref rate, rate.Length + 1);
        //        Console.Write("Enter your rate:");
        //        int newRate = int.Parse(Console.ReadLine());
        //        rate[rate.Length - 1] = newRate;
        //    }
        //    return rate;
        //}
    }
}
