using System;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace IOFIle2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Admin\Documents\project\project\c-sharp\IOFIle2\IOFIle2\File\";
            string inputPath = "db.json";
            string outputPath1 = "output1.json";
            string outputPath2 = "output2.json";
            JsonFiles files = new JsonFiles(path, inputPath, outputPath1, outputPath2);
            files.ReadFile();
            files.CreateOuputJson1();
            files.CreateOutputJson2();
        }
    }
}
