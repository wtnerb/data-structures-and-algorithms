using System;
using System.Collections.Generic;
using System.Text;

namespace ll_find_loop
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
            Head = null;
            for (int i = values.Length-1; i >= 0; i--)
            {
                Add(values[i]);
            }
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

        public Node KthFromEnd(int k)
        {
            int len = Length() - 1;
            Node current = Head;
            for (int i = 0; i < len - k; i++)
            {
                current = current.Next;
            }
            return current;
        }

        /// <summary>
        /// Combines two linked lists by "zipping" them together. The Head of the current list will be the head of the merged list.
        /// </summary>
        /// <param name="ll">the other linked list to be merged into this one</param>
        public void LinkedListMerge(LinkedList ll)
        {
            Node current = Head;
            Node cache = ll.Head;
            bool s = true;
            while (cache.Next != null)
            {
                Node temp = current.Next;
                current.Next = cache;
                cache = temp;
                current = current.Next;
            }
            cache.Next = current.Next;
            current.Next = cache;
        }

        /// <summary>
        /// Retrieves node at a given depth into the list. Like an index, but less efficient.
        /// </summary>
        /// <param name="depth">the depth of the desired node from the Head. 0-indexed</param>
        /// <returns>Node at that position</returns>
        public Node Item (int depth)
        {
            Node current = Head;
            for (int i = 0; i < depth; i++)
            {
                current = current.Next;
            }
            return current;
        }

        /// <summary>
        /// Checks a linked list for circular reference.
        /// </summary>
        /// <returns>true if circular, false otherwise.</returns>
        public bool HasLoop()
        {
            try
            {
                Node current = Head;
                Node current2 = Head.Next;
                while (current2 != current && current2.Next != current)
                    // if the fast runner is behind the slow runner, a loop is in the ll
                    //Note: two seemingly identical nodes will not cause error. When comparing objects c#
                    //also compares the reference. Only when refering to that exact instance will node != node
                    //evaluate to false.
                {
                    current = current.Next;
                    current2 = current2.Next.Next;
                }
            }
            catch
            {
                //if not a loop, eventually null.Next will be attempted and throw an exception
                return false;
            }
            //if while loop terminates without throwing an exception, ll has a loop.
            return true;
        }
    }
}
