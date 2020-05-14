using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IODemo
{
    class LogDemo
    {
        public static void Main(string[] args)
        {
            string fileName = $"[Error]{DateTime.Now.ToString("dd-MM-yyyy_hh-mm")}.txt";
            string path = @$"C:\Users\Admin\Documents\project\project\c-sharp\IODemo\IODemo\Files\{fileName}";
            try
            {
                int a = 8;
                int b = 0;
                Console.WriteLine(a / b);
            }
            catch(Exception e)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine($"{DateTime.Now.ToString("hh:mm:ss")} {e.Message}");
                }
            }
        }
    }
}
