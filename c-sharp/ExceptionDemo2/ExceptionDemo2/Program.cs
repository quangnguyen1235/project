using System;
using System.Collections.Generic;

namespace ExceptionDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                List<char> chacraters = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f' };
                int value = chacraters[6];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"{ex.GetType().Name} {ex.Message} {DateTime.Now.ToLocalTime()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType().Name}: {ex.Message} ");
            }
        }
    }
}
