using Bai3.Modal;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Data;

namespace Bai3.Service
{
    class LoginService
    {
        public string input { get; set; }
        public string output { get; set; }
        public ListStaff listStaff;
        //public Staff staff;
        //public Login login;
        public LoginService(string input, string output)
        {
            this.input = input;
            this.output = output;
            listStaff = new ListStaff()
            {
                staffs = new List<Staff>()
            };
        }
        public void ReadLoginDetail()
        {
            using (StreamReader sr = File.OpenText(input))
            {
                var obj = sr.ReadToEnd();
                listStaff = JsonConvert.DeserializeObject<ListStaff>(obj);
            }
        }
        public void WriteLoginDetail()
        {
            using (StreamWriter sw = File.CreateText(output))
            {
                var data = JsonConvert.SerializeObject(listStaff);
                sw.Write(data);
            }
        }
        public void CreateLogin(string name, string email, string pass)
        {
            listStaff.CreateStaff(name, email, pass);
            WriteLoginDetail();
        }
        public void EditPass(string pass, Staff staff)
        {
            if (staff.loginDetail.Pass == pass)
            {
                Console.Write("Input new Pass");
                string newPass = Console.ReadLine();
                staff.EditPassWord(newPass);
                WriteLoginDetail();
            }
            else
            {
                Console.WriteLine("Wrong Password");
            }
        }
        public Staff CheckLogin(string email, string pass, out string name)
        { 
            foreach(var item in listStaff.staffs)
            {
                if(item.loginDetail.Email == email && item.loginDetail.Pass == pass)
                {
                    name = item.name;
                    return item;
                }
            }
            name = "";
            return null;
        }
    }
}
