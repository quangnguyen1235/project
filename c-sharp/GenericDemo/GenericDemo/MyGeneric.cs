using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDemo
{
    class MyGeneric<T> where T : class
    {
        public T[] MG = new T[0];
        public MyGeneric()
        {

        }
        public void Add(T value)
        {
            Array.Resize(ref MG, MG.Length + 1);
            MG[MG.Length-1] = value;
        }
        public void RemoveAt(int index)
        {
            if (index >= 0 && index < MG.Length)
            {
                for (int i = index; i < MG.Length - 1; i++)
                {
                    MG[i] = MG[i + 1];
                }
                Array.Resize(ref MG, MG.Length - 1);
            }
        }
        public void Remove(T value)
        {
            int pos = -1;
            for (int i = 0; i < MG.Length; i++)
            {
                if (MG[i] == value)
                {
                    pos = i;
                    break;
                }
            }
            RemoveAt(pos);
        }
        public void Update (int index, T value)
        {
            MG[index] = value;
        }
        public void Update (T Oldvalue, T Newvalue)
        {
            int pos = -1;
            for (int i = 0; i < MG.Length; i++)
            {
                if (MG[i] == Oldvalue)
                {
                    pos = i;
                    break;
                }
            }
            Update(pos, Newvalue);
        }
    }
}
