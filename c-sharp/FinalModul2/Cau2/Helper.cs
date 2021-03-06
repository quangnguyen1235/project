﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FinalModul2
{
    static class Helper
    {
        public static string InputField(string disPlayMesage, Regex regex, string error)
        {
            Console.Write(disPlayMesage);
            try
            {
                string result = Console.ReadLine();
                Match format = regex.Match(result);
                if (format.Success == false)
                {
                    throw new Exception(error);
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}
