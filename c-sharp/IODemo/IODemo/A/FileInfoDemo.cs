using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IODemo.A
{
    class FileInfoDemo
    {
        public static void Main(string[] args)
        {
            string parthInput = @"C:\Users\Admin\Documents\project\project\c-sharp\IODemo\IODemo\Files\input.txt";
            FileInfo fileInfo = new FileInfo(parthInput);
            using (StreamReader sr = fileInfo.OpenText())
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
