using System;
using System.IO;
namespace IODemo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string path = @"C:\Users\Admin\Documents\project\project\c-sharp\IODemo\IODemo\Files\quang.txt";
            //if (File.Exists(path))
            //{
            //    File.Delete(path);
            //}
            //using (StreamWriter sw = File.CreateText(path))
            //{
            //    sw.WriteLine("Hello My Friend");
            //}
            using (StreamReader sr = File.OpenText(path))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            //File.Create(path);
        }
    }
}
