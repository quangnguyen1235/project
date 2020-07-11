using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SchoolManagement
{
    public static class Helper
    {
        public static string InputField(string label, Regex regex, string error)
        {
            Match format;
            do
            {
                Console.Write(label);
                format = regex.Match(Console.ReadLine());
                if (!format.Success)
                {
                    Exception e = new Exception(error);
                    Console.WriteLine(e.Message);
                }
            } while (!format.Success);
            return format.ToString().ToUpper();
        }
    }
}
