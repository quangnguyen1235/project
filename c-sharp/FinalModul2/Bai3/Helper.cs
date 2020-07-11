using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FinalModul2
{
    static class Helper
    {
        public static string InputField(string disPlayMesage, Regex regex, string error)
        {
            string result = "";
            Match format;
            do
            {
                Console.Write(disPlayMesage);
                result = Console.ReadLine();
                format = regex.Match(result);
                if (!format.Success)
                {
                    Console.WriteLine(new Exception(error).Message);
                }
            } while (!format.Success);
            return result;
        }
    }
}
