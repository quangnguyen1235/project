using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace NewsManagementSystem
{
    interface INews
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        void Display();
    }
}
