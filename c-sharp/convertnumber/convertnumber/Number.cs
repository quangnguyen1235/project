using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace convertnumber
{
    public class Number
    {
        private int numbersystem;
        private string num;
        public int NumberSystem
        {
            get => numbersystem;
            set => numbersystem = value;
        }
        public string Num
        {
            get => num;
            set => num = value;
        }
        public Number(int Numbersystem, string Num)
        {
            this.numbersystem = Numbersystem;
            this.num = Num;
        }
        public int[] StringToNum(string num)
        
        {
            int[] numConvertedz = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
            {

                if (num[i] == 'A' || num[i] == 'B' || num[i] == 'C' || num[i] == 'D' || num[i] == 'E' || num[i] == 'F')
                {
                    switch (num[i])
                    {
                        case 'A':
                            {
                                numConvertedz[i] = 10;
                                break;
                            }
                        case 'B':
                            {
                                numConvertedz[i] = 11;
                                break;
                            }
                        case 'C':
                            {
                                numConvertedz[i] = 12;
                                break;
                            }
                        case 'D':
                            {
                                numConvertedz[i] = 13;
                                break;
                            }
                        case 'E':
                            {
                                numConvertedz[i] = 14;
                                break;
                            }
                        case 'F':
                            {
                                numConvertedz[i] = 15;
                                break;
                            }
                    }
                }
                else
                {
                    numConvertedz[i] = Convert.ToInt32(new string(num[i], 1));
                }
            }
            return numConvertedz;
        }
        public double ConvertNumber(int numberSystem, int[] numberConverted)
        {
            double number = 0;
            for (int i = numberConverted.Length - 1; i >= 0; i--)
            {
                number += numberConverted[i] * Math.Pow(numberSystem, numberConverted.Length - 1 - i);
            }
            return number;
        }
    }
}
