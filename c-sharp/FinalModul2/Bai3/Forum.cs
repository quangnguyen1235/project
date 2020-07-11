using Cau3;
using FinalModul2;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{

    class Forum
    {
        static int Increment = 0;
        public List<Post> PostList = new List<Post>();
        public void Main()
        {
            Menu();
        }
        public void Menu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("1.Create Post");
                Console.WriteLine("2.Calculator");
                Console.WriteLine("3.SHow List");
                Console.WriteLine("4.Exit");
                Console.Write("Opt: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }
            }
            while (option < 1 || option > 4);
            Process(option);
        }
        public void Process(int opt)
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
                        Calculator();
                        break;
                    }
                case 3:
                    {
                        ShowInfo();
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
        public void CreatePost()
        {
            Post newAccount = Post.InputAccountInfomation(ref Increment);
            if (newAccount != null)
            {
                string[] arr = new string [newAccount.RateList.Length];
                for (int i = 0; i < newAccount.RateList.Length; i++)
                {
                    arr[i] = Helper.InputField($"Input Rate {i}: ", MyRegex.number, Constaints.ERROR_UNFORMAT_ID);
                    newAccount.RateList[i] = float.Parse(arr[i]);
                }
                PostList.Add(newAccount);
            }
            else
            {
                Console.WriteLine("Invallid Account");
            }
        }
        public void Calculator()
        {
            foreach(var item in PostList)
            {
                item.CalculateRate();
            }
        }
        public void ShowInfo()
        {
            foreach (var item in PostList)
            {
                item.Display();
            }
        }
    }
}
