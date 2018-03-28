using System;

namespace kth_from_end
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            LinkedList l = new LinkedList(new int[] { 1, 5, 3, 6, 7 });
            l.KthFromEnd(1);
            Console.ReadKey();
        }
    }
}
