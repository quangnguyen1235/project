using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace IODemo
{
    class DirectoryDemo
    {
        public static string path = @"C:\Users\Admin\Documents\project\project\c-sharp\IODemo\IODemo";
        public static void Main(string[] args)
        {
            Directory.CreateDirectory($@"{path}\A\B");
            //Directory.Delete("");
            Directory.Move($@"{path}\A", $@"{path}\D");
            //Directory.Exists();
        }
    }
}
