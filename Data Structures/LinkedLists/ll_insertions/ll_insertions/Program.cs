using System;

namespace ll_insertions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList example = new LinkedList(new int[] { 1, 5, 8, 26, 4});
            Console.WriteLine($"Example:");
            RenderLL(example);
            Console.WriteLine("After appending -5");
            RenderLL(Append(example, -5));
            Console.WriteLine();
            Console.WriteLine("Insert -4 before 26");
            RenderLL(InsertBefore(example, 26, -4));
            Console.WriteLine();
            Console.WriteLine("Insert -2 after 5");
            RenderLL(InsertAfter(example, 5, -2));
        }

        public static LinkedList InsertAfter(LinkedList ll, int target, int val)
        {
            Node current = ll.Head;
            while (current.Value != target)
            {
                current = current.Next;
            }
            Node insertion = new Node(val);
            insertion.Next = current.Next;
            current.Next = insertion;
            return ll;
        }

        public static LinkedList InsertBefore(LinkedList ll, int target, int val)
        {
            Node current = ll.Head;
            while (current.Next.Value != target)
            {
                current = current.Next;
            }
            Node insertion = new Node(val);
            insertion.Next = current.Next;
            current.Next = insertion;
            return ll;
        }

        public static LinkedList Append(LinkedList ll, int val)
        {
            Node current = ll.Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            Node toAppend = new Node(val);
            current.Next = toAppend;
            return ll;
        }

        public static void RenderLL (LinkedList ll)
        {
            Node current = ll.Head;
            while (current != null)
            {
                Console.Write($"{current.Value} --> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }

        public static bool CompareLL (LinkedList ll1, LinkedList ll2)
        {
            Node current1 = ll1.Head;
            Node current2 = ll2.Head;
            while (current1 != null && current2 != null)
            {
                if (current1.Value != current2.Value)
                {
                    return false;
                }
                current1 = current1.Next;
                current2 = current2.Next;
            }
            if (current1 != null || current2 != null)
            {
                return false;
            }
            return true;
        }
    }
}
