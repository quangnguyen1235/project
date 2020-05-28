using Bai3.Service;
using System;
using System.ComponentModel;
using System.Security.Cryptography;
using Bai3.Modal;

namespace Bai3
{
    
    class Program
    {
        public static string inputOutputLogin = @"C:\Users\Admin\Documents\project\project\c-sharp\Review\Bai3\DataBase\Staffs.json";
        public static string inputOutputOrder = @"C:\Users\Admin\Documents\project\project\c-sharp\Review\Bai3\DataBase\OrderData.json";
        public static LoginService loginService = new LoginService(inputOutputLogin, inputOutputLogin);
        public static OrderService orderService = new OrderService(inputOutputOrder, inputOutputOrder);
        static void Main(string[] args)
        {

            //loginService.ReadLoginDetail();
            //orderService.ReadOderData();
            //Staff obj = Login();
            //Console.Write("input name: ");
            //string name = Console.ReadLine();
            //Console.Write("input email: ");
            //string email = Console.ReadLine();
            //Console.Write("input pass: ");
            //string pass = Console.ReadLine();
            //loginService.CreateLogin(name, email, pass);
            //orderService.ShowOrder();
            //orderService.EditCustomer("trung", "26NTp", orderService.CheckOrder(1));
            //orderService.SearchOrder(2);
            orderService.SearchOrder("Quang Nguyen", "37 NTP");
            orderService.

        }
        static Staff Login()
        {
            Staff obj = null;
            do
            {
                Console.WriteLine("<------------------Login------------------>");
                Console.Write("Input email: ");
                string email = Console.ReadLine();
                Console.Write("Input password: ");
                string pass = Console.ReadLine();
                obj = loginService.CheckLogin(email, pass, out string name);
                Console.Clear();
                if (obj == null)
                {
                    Console.WriteLine("Invallid email or password");
                }
                else
                {
                    Console.WriteLine($"<------------------{name}------------------>");
                }
            } while (obj == null);
            return obj;
        }
        static void EditPass(Staff obj)
        {
            Console.Write("input former password: ");
            string formerPass = Console.ReadLine();
            loginService.EditPass(formerPass, obj);
        }
    }
}
