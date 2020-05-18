using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IOFIle2
{
    class JsonFiles
    {
        public string Path;
        public string InputFile;
        public string OutputFile1;
        public string OutputFile2;
        public Payload Data;
        public JsonFiles(string path, string inputFile, string outputFile1, string outputFile2)
        {
            Path = path;
            InputFile = inputFile;
            OutputFile1 = outputFile1;
            OutputFile2 = outputFile2;
        }
        public void ReadFile()
        {
            using StreamReader sr = File.OpenText(Path + InputFile);
            var json = sr.ReadToEnd();
            Data = JsonConvert.DeserializeObject<Payload>(json);
            foreach(var item in Data.number)
            {
                item.ToString();
            }
        }
        public void CreateOuputJson1()
        {
            using StreamWriter sw = File.CreateText(Path + OutputFile1);
            List<int> SumOfNum = new List<int>();
            foreach(var item in Data.number)
            {
                SumOfNum.Add(item.Sum());
            }
            var obj = JsonConvert.SerializeObject((object)SumOfNum);
            sw.WriteLine(obj);
        }
        public void CreateOutputJson2()
        {
            using StreamWriter sw = File.CreateText(Path + OutputFile2);
            List < Number > multy = new List<Number>();
            foreach(var item in Data.number)
            {
                multy.Add(item.Multi(2));
            }
            var obj = JsonConvert.SerializeObject((object)multy);
        }
    }
}
