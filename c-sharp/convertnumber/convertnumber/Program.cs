using System;
using System.Text;
using System.Collections.Generic;
namespace convertnumber
{
    public class Program
    {
        public static void Main()
        {
            Init();
        }
        public static void Init()
        {
            int[] numConverted;
            string number="";
            bool check = false;
            int numberStyle = InputNumStyle();
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Please Reinput number");
            //    number = InputNumber().ToUpper();
            //    CheckStyleNumber(numberStyle, ref number, ref check);
            //}
            while (check == false)
            {
                Console.Clear();
                number = InputNumber().ToUpper();
                CheckStyleNumber(numberStyle, ref number, ref check);
            };
            Number numb = new Number(numberStyle, number);
            numConverted = numb.StringToNum(number);
            Console.WriteLine($"Dec:{numb.ConvertNumber(numberStyle, numConverted)}");
        }
        public static int InputNumStyle()
        {
            int numberStyle = 0;
            do
            {
                Console.Write("Please input Number Style (2,8,16):");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    numberStyle = number;
                }
                Console.Clear();
            } while ((numberStyle != 2) && (numberStyle != 8) && (numberStyle != 16));
            return numberStyle;
        }
        public static string InputNumber()
        {
            string number;
            Console.Write("Please Input number: ");
            number = Console.ReadLine();
            return number;
        }
        public static bool CheckStyleNumber(int numberStyle, ref string number, ref bool check)
        {
            switch (numberStyle)
            {
                case 2:
                    {
                        for (int i = 0; i < number.Length; i++)
                        {
                            if (number[i]!= '0' && number[i] != '1')
                            {
                                check = false;
                            }
                            else
                            {
                                check = true;
                            }
                        }
                        break;
                    }
                case 8:
                    {
                        for (int i = 0; i < number.Length; i++)
                        {
                            if (number[i] != '0' && number[i] != '1' && number[i] != '2' && number[i] != '3' &&
                                number[i] != '4' && number[i] != '5' && number[i] != '6' && number[i] != '7')
                            {
                                check = false;
                            }
                            else
                            {
                                check = true;
                            }

                        }
                        break;
                    }
                case 16:
                    {
                        for (int i = 0; i < number.Length; i++)
                        {
                            if (number[i] != '0' && number[i] != '1' && number[i] != '2' && number[i] != '3' &&
                                number[i] != '4' && number[i] != '5' && number[i] != '6' && number[i] != '7' &&
                                number[i] != '8' && number[i] != '9' && number[i] != 'A' && number[i] != 'B' && 
                                number[i] != 'C' && number[i] != 'D' && number[i] != 'E' && number[i] != 'F')
                            {
                                check = false;
                            }
                            else
                            {
                                check = true;
                            }
                        }
                        break;
                    }
            }
            return check;
        }
    }
}
