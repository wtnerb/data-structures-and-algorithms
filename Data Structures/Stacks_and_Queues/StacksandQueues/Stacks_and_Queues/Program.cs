using System;

namespace Stacks_and_Queues
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stack st = new Stack();
            st.Push(new Node(5));
            st.Push(new Node(3));
            st.Push(new Node(8));
            Console.WriteLine("stack shoule look like 8 -> 3 -> 5");
            st.Render();
            st.Pop();
            st.Render();
            Console.WriteLine();
            Queue q = new Queue();
            q.Enqueue(new Node(7));
            q.Enqueue(new Node(79));
            q.Enqueue(new Node(-7));
            q.Enqueue(new Node(72));
            Console.WriteLine("Queue should look like 72 -> -7 -> 79 -> 7");
            q.Render();
            q.Dequeue();
            q.Render();
        }

        /// <summary>
        /// Treats two stacks like a queue. Add item to a queue
        /// </summary>
        /// <param name="q">the "queue" in question, held in a stack</param>
        /// <param name="value">the value to be added to the queue</param>
        /// <returns></returns>
        static public Stack Enqueue(Stack q, int value)
        {
            Stack holder = new Stack();
            //flip the queue upside down
            while (q.Peek() != null)
            {
                holder.Push(q.Pop());
            }

            //Add new item to bottom of "queue" stack (it now being empty)
            q.Push(new Node(value));

            //Reload the stack with all the items that got popped.
            while (holder.Peek() != null)
            {
                q.Push(holder.Pop());
            }
            return q;
        }

        //removes top item from queue stack
        public static int Dequeue(Stack q)
        {
            return q.Pop().Value;
        }
    }
}
