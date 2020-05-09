using System;
using System.Collections.Generic;
using System.Text;

namespace BooksManagementSystem
{
    class Book : Ibook
    {
        private int id;
        private string name;
        private DateTime publishDate;
        private string author;
        private string language;
        private float averagePrice;
        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime PublishDate { get => publishDate; set => publishDate = value; }
        public string Author { get => author; set => author = value; }
        public string Language { get => language; set => language = value; }

        public float AveragePrice => averagePrice;
        public int[] PriceList = new int[5];
        public Book(int id, string name, DateTime publishDate, string author, string language)
        {
            this.id = id;
            this.name = name;
            this.publishDate = publishDate;
            this.author = author;
            this.language = language;
        }

        public void DisPlay()
        {
            Console.WriteLine($"{id}. {name}\n PublishDate: {publishDate}\t Author: {author}\t Language: {language}\t AveragePrice: {averagePrice}");
        }
        public void CalculatorAveragePrice()
        {
            int total = 0;
            foreach (var price in PriceList)
            {
                total += price;
            }
            averagePrice = ((float)(total)) / PriceList.Length;
        }
    }
}
