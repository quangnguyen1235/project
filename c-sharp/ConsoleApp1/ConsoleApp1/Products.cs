using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagementSystem
{
    public class Products
    {
        private string name;
        private string description;
        private double price;
        private double[] rate;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Description
        {
            get => description;
            set => description = value;
        }
        public double Price
        {
            get => price;
            set => price = value;
        }
        public double[] Rate
        {
            get => rate;
            set => rate = value;
        }
        //public Products(string Name, string Description, double Price, double[] Rate)
        //{
        //    this.name = Name;
        //    this.description = Description;
        //    this.price = Price;
        //    this.rate = Rate;
        //}
        public void viewInfo()
        {
            Console.Write($"Name: {Name}\t Description: {Description}\t Price: {Price}");
        }
        
        public double averageRate(double[] ratePoin)
        {
            double sum = 0;
            for(int i = 0; i < ratePoin.Length; i++)
            {
                sum += ratePoin[i];
            }
            if (ratePoin.Length > 0)
            {
                return (sum / (ratePoin.Length));
            }
            else
            {
                return 0;
            }
        }
        public double[] setRate()
        {
            Console.Write("Pls Enter how many vote: ");
            int amount = int.Parse(Console.ReadLine());
            double[] rate = new double[0];
            for (int i = 0; i < amount; i++)
            {
                Array.Resize(ref rate, rate.Length + 1);
                Console.Write("Enter your rate:");
                int newRate = int.Parse(Console.ReadLine());
                rate[rate.Length - 1] = newRate;
            }
            return rate;
        }
    }
}
