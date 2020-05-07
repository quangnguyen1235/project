using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace NewsManagementSystem
{
    class News : INews
    {
        private int id = 1;
        private string title;
        private DateTime publishDate;
        private string author;
        private string content;
        private float averangeRate;
        public int[] RateList = new int[3];
        public int ID { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public DateTime PublishDate { get => publishDate; set => publishDate = value; }
        public string Author { get => author; set => author = value; }
        public string Content { get => content; set => content = value; }
        public float AverangeRate
        {
            get => averangeRate;
        }
        public void Display()
        {
            Console.WriteLine($"Title: {title}\t PublishDate: {publishDate}\t Author: {author}\t Content: {content}\t AverangeRate: {averangeRate}");
        }
        public float Calculate()
        {
            return averangeRate = ((float)(RateList[0] + RateList[1] + RateList[2])) / 3;
        }
    }
}
