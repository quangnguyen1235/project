using System;
using System.Collections.Generic;
using System.Text;
using StudentManagementJson.Models;
using StudentManagementJson.Common;
using System.IO;
using Newtonsoft.Json;

namespace StudentManagementJson.Service
{
    class JsonService
    {
        private string input;
        private string output;
        private Payload payload;
        private Result result;
        public JsonService(string input, string output)
        {
            this.input = input;
            this.output = output;
        }
        public void ReadFile()
        {
            payload = new Payload()
            {
                students = new List<Student>()
            };
            using (StreamReader sr = File.OpenText(input))
            {
                var obj = sr.ReadToEnd();
                payload = JsonConvert.DeserializeObject<Payload>(obj);
            }
        }
        public void ProcessData()
        {
            result = new Result()
            {
                results = new SortedList<double, StudentOutput>()
            };
            foreach(var item in payload.students)
            {
                var res = new StudentOutput(item.id, item.name, item.gender, item.level, item.AverageScores(), item.Rank());
                result.results.Add(res.averageScore, res);
            }
        }
        public void WriteFile()
        {
            ProcessData();
            using (StreamWriter sw = File.CreateText(output))
            {
                var data = JsonConvert.SerializeObject(result.results.Values);
                sw.Write(data);
            }
        }
    }
}
