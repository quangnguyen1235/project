using System;
using System.Collections.Generic;
using System.Text;

namespace MyListGeneric
{
    class MyList<T>
    {
        private int length;
        public Object[] items;
        public int Length { get; set; }
        public MyList()
        {
            items = new Object[10];
        }
        public void EnsureCapacity()
        {
            int newSize = items.Length * 2;
            //Array.Copy(items, items, newSize);
            Array.Resize<Object>(ref items, newSize);
        }
        public void Add(T value)
        {
            if(Length == items.Length)
            {
                EnsureCapacity();
            }
            items[Length++] = value;
            //items[items.Length - 1] = value;
        }
        public T GetData(int index)
        {
            if(index >= Length || index < 0)
            {
                throw new IndexOutOfRangeException("The elements is not exist");
            }
            return (T)items[index]; 
        }
        public void Remove(int index)
        {

        }
    }
}
