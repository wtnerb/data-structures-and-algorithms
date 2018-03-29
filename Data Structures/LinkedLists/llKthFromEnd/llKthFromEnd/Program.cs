using System;

namespace kth_from_end
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList l = new LinkedList(new int[] { 1, 5, 3, 6, 7 });
            Node result0 = l.KthFromEnd(0);
            Node expect0 = new Node(1);
            Node result1 = l.KthFromEnd(1);
            Node expect1 = new Node(5);
            expect1.Next = new Node(1);
            Console.WriteLine(expect0 == result0); 
            Console.ReadKey();
        }
    }
}
