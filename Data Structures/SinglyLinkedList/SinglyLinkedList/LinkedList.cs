using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedList
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList(int value)
        {
            Head = new Node(value);
        }
        public LinkedList(int[] values)
        {
            LinkedList l = new LinkedList(values[0]);
            for (int i = 1; i < values.Length; i++)
            {
                l.Add(values[i]);
            }
            Head = l.Head;
        }

        public void Add (int value)
        {
            Node addition = new Node(value);
            Node oldHead = Head;
            addition.Next = oldHead;
            Head = addition;
        }

        public int Find (int value)
        {
            int index = 0;
            Node current = Head;
            do
            {
                if (current.Value == value)
                {
                    return index;
                }
                index++;
                current = current.Next;
            } while (current.Next != null);
            return -1;
        }
    }
}
