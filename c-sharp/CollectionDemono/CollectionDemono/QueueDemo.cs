using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CollectionDemono.QueueDemo
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue Q = new Queue();
            for (int i =0; i< 10; i++)
            {
                Q.Enqueue(i + 1);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Q.Peek());
                Q.Dequeue();
            }
        }
    }
}
