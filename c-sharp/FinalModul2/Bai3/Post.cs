using Cau3;
using FinalModul2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    class Post : IPost
    {
        public float[] RateList = new float[4];
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public float AverangeRate { get; private set; }
        public Post(int id, string title, string author, string content)
        {
            this.ID = id;
            this.Title = title;
            this.Author = author;
            this.Content = content;
        }
        public void CalculateRate()
        {
            float sum = 0;
            foreach (var item in RateList)
            {
                sum += item; 
            }
            AverangeRate = sum / RateList.Length;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {ID}\t\t Title: {Title}\t\t Author: {Author}\t\t Content: {Content}\t\t AverangeRate: {AverangeRate}");
        }
        static public Post InputAccountInfomation(ref int id)
        {
            string title = Helper.InputField("Input Title: ", MyRegex.name, Constaints.ERROR_INVALLID_NAME);
            string author = Helper.InputField("Input Author: ", MyRegex.name, Constaints.ERROR_INVALLID_NAME);
            string content = Helper.InputField("Input content: ", MyRegex.name, Constaints.ERROR_INVALLID_NAME);
            Post post = new Post(id, title, author, content);
            id++;
            return post;
        }
    }
}
