using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;

namespace IODemo
{
    class JsonDemo
    {
        public static string pathInput = @"C:\Users\Admin\Documents\project\project\c-sharp\IODemo\IODemo\Files\db.json";
        public static void Main()
        {
            using (StreamReader sr = File.OpenText(pathInput))
            {
                var json = sr.ReadToEnd();
                var data = JsonConvert.
                
            }
        }
        class PayLoad
        {
            public List<ProductorderInfomation> ProductorderInfomations { get; set; }
        }
        class ProductorderInfomation
        {
            public int id { get; set; }
            public string name { get; set; }
            public string phonenumber { get; set; }
            public string address { get; set; }
            public override string ToString()
            {
                return $"id: {id}\t name: {name}\t phonenumber: {phonenumber}\t address: {address}";
            }
        }
    }
}
