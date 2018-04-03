using System;

namespace Stacks_and_Queues
{
    class Program
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
    }
}
