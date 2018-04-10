using System;

namespace Stacks_and_Queues
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(new Node(5));
            st.Push(new Node(3));
            st.Push(new Node(8));
            Console.WriteLine("Starting queue is Head 8 -- 3 -- 5 Rear");
            st.Render();
            Console.WriteLine("Now lets call that our queue stack. 8 is at the head of the queue, 5 at the back.");
            Console.WriteLine("Enqueue 6 ...");
            st = Enqueue(st, 6);
            Console.WriteLine("new queue: ");
            st.Render();
            Console.WriteLine();
            Console.WriteLine("And to dequeue, since 8 is at the head, we should retrieve 8");
            int temp = Dequeue(st);
            Console.WriteLine($"Dequeued: {temp}");
            Console.WriteLine("The new 'queue' looks like:");
            st.Render();
            Console.ReadKey();
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
