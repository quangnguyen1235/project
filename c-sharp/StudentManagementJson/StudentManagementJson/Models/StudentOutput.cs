using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StudentManagementJson.Models
{
    class StudentOutput
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool gender { get; set; }
        public string level { get; set; }
        public double averageScore { get; set; }
        public string rank { get; set; }
        public StudentOutput(int id, string name, bool gender, string level, double averageScore, string rank)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.level = level;
            this.averageScore = averageScore;
            this.rank = rank;
        }

    }
}
