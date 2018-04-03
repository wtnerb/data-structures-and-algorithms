using System;

namespace ll_find_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("input non circular loop");
            LinkedList ll1 = new LinkedList(new int[] { 1, 5, 2, 83, 2 });
            RenderLL(ll1);
            Console.WriteLine($"Is a loop: {ll1.HasLoop()}");
            Console.WriteLine("\nNow making tail point to head ...");
            Node current = ll1.Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = ll1.Head;
            Console.WriteLine("Linked list now ouroboros-ified");
            Console.WriteLine($"Is a loop: {ll1.HasLoop()}");
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }


        public static void RenderLL(LinkedList ll)
        {
            Node current = ll.Head;
            while (current != null)
            {
                Console.Write($"{current.Value} --> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}
