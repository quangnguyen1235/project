using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Examination
{
    class Forum <T> where T : class
    {
        public SortedList<int, Post> Posts = new SortedList<int, Post>();
        public void Add(int key, Post post)
        {
            Posts.Add(key, post);
            post.CalculatorRate();
        }
        public void Update(int key, string content)
        {
            foreach(KeyValuePair<int, Post> post in Posts)
            {
                if(post.Value.ID == key)
                {
                    post.Value.Content = content;
                }
            }
        }
        public void Remove(int id)
        {
            Posts.RemoveAt(id-1);
        }
        public void Show()
        {
            foreach(KeyValuePair<int, Post> post in Posts)
            {
                post.Value.Display();
            }
        }
    }
}
