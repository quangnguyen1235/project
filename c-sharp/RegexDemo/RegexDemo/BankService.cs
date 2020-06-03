using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Specialized;
using System.Collections;
using System.Linq;

namespace RegexDemo
{
    class BankService
    {
        public Bank bank;
        public string inputOutput { get; set; }
        public BankService(string inputOutput)
        {
            this.inputOutput = inputOutput;
            bank = new Bank()
            {
                listAcount = new Dictionary<int, Account>()
            };
        }
        public void ReadJson()
        {
            using (StreamReader sr = File.OpenText(inputOutput))
            {
                var obj = sr.ReadToEnd();
                bank.listAcount= JsonConvert.DeserializeObject<Dictionary<int, Account>>(obj);
            }
        }
        public void WriteJson()
        {
            using (StreamWriter sw = File.CreateText(inputOutput))
            {
                var data = JsonConvert.SerializeObject(bank.listAcount.Values);
                sw.Write(data);
            }
        }
    }
}
