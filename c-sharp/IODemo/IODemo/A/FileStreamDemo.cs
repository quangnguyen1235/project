using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IODemo
{
    class FileStreamDemo
    {
        public static void Main()
        {
            string pathInput = @"C:\Users\Admin\Documents\project\project\c-sharp\IODemo\IODemo\Files\input.txt";
            FileStream filestream = new FileStream(pathInput, FileMode.OpenOrCreate);
            using (StreamReader sr = new StreamReader(filestream))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
