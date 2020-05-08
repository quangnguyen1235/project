using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Examination
{
    class Post : IPost
    {
        private int id;
        private string title;
        private string content;
        private string author;
        private float averageRate;
        public int ID { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public string Author { get => author; set => author = value; }
        public float AverageRate { get => averageRate; }
        public int[] Rates = new int[3];
        public Post (int id, string title, string content, string author)
        {
            this.id = id;
            this.title = title;
            this.content = content;
            this.author = author;
        }
        public float CalculatorRate()
        {
            return averageRate = ((float)(Rates[0] + Rates[1] + Rates[2])) / 3;
        }

        public void Display()
        {
            Console.WriteLine($"{id}. Title: {title}\t Content: {content}\t Author: {author}\t AverageRate: {averageRate}");
        }
    }
}
