using System;
using System.Collections.Generic;
using System.Text;

namespace MyLinkedListGeneric
{
    class MyLinkedList
    {
        Node Head;
        int NodeCnt = 0;
        public MyLinkedList(Object Data)
        {
            Head = new Node(Data);
        }
        public void Add(Object data, int index)
        {
            Node temp = Head;
            Node holder;
            for (int i = 0; i < index - 1 && temp.Next != null; i++)
            {
                temp = temp.Next;
            }
            holder = temp.Next;
            temp.Next = new Node(data);
            temp.Next.Next = holder;
            NodeCnt++;
        }
        public void AddFirst(Object data)
        {
            Node temp = Head;
            Head = new Node(data);
            Head.Next = temp;
            NodeCnt++;
        }
        public Node GetData(int index)
        {
            Node temp = Head;
            for(int i = 0; i < index; i++)
            {
                temp = temp.Next;
            }
            return temp;
        }
    }
}
