using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_and_Queues
{
    public class Queue
    {
        public Node Head { get; set; } = null;
        public Node Tail { get; set; } = null;

        /// <summary>
        /// Adds an item to the queue
        /// </summary>
        /// <param name="node">Node to add</param>
        public void Enqueue(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head.Prev = node;
                Head = node;
            }
        }

        /// <summary>
        /// Retrieves an item from the back of the queue
        /// </summary>
        /// <returns></returns>
        public Node Dequeue()
        {
            try
            {
                Node output = Tail;
                Tail = Tail.Prev;
                Tail.Next = null;
                return output;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Returns the tip of the queue
        /// </summary>
        /// <returns></returns>
        public Node Peek()
        {
            return Tail;
        }

        /// <summary>
        /// Prints the queue from uead to tail to the console.
        /// </summary>
        public void Render()
        {
            Console.Write("Head " );
            Node current = Head;
            while (current != null)
            {
                Console.Write($"{current.Value} --> ");
                current = current.Next;
            }
            Console.WriteLine("Tail");
        }

    }
}
