using System;
using System.Collections.Generic;
using System.Text;

namespace kth_from_end
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

        public void Add(int value)
        {
            Node addition = new Node(value);
            Node oldHead = Head;
            addition.Next = oldHead;
            Head = addition;
        }

        public int Find(int value)
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

        public int Length()
        {
            Node current = Head;
            int count = 1;
            while (current.Next != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public Node KthFromEnd (int k)
        {
            int len = Length() - 1;
            Node current = Head;
            for (int i = 0; i < len - k; i++)
            {
                current = current.Next;
            }
            return current;
        }
    }
}
