using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagementSystem
{
    public class Shop
    {
        Products[] productsList = new Products[0];
        public void AddProduct(Products newProducts)
        {
            Array.Resize(ref productsList, productsList.Length + 1);
            productsList[productsList.Length - 1] = newProducts;
        }
        public bool Check(string Name)
        {
            bool check = false;
            for (int i = 0; i < productsList.Length; i++)
            {
                if (productsList[i].Name == Name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public void RemoveProduct(string Name)
        {
            for (int i = 0; i < productsList.Length; i++)
            {
                if (Check(Name))
                {
                    List<Products> list = new List<Products>(productsList);
                    list.RemoveAt(i);
                    productsList = list.ToArray();
                    Console.WriteLine("Done!");

                }
            }
        }
        public void SearchProduct(double num1, double num2)
        {
            for (int i = 0; i < productsList.Length; i++)
            {
                if ((productsList[i].Price >= num1) && (productsList[i].Price <= num2))
                {
                    productsList[i].viewInfo();
                }
            }
        }
        public void IterateProductList()
        {
            for ( int i = 0; i < productsList.Length; i++)
            {
                productsList[i].viewInfo();
                Console.ReadLine();
                Console.WriteLine($"Rate is:{productsList[i].averageRate(productsList[i].Rate)}");
                Console.ReadKey();
            }
        }
    }
}
