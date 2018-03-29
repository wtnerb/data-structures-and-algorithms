using System;

namespace LLMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 3, 5, 9 };
            int[] arr2 = { 2, 4, 6 };
            LinkedList test = new LinkedList(arr1);
            LinkedList test2 = new LinkedList(arr2);
            PrintLinkedList(test);
            PrintLinkedList(test2);
            test.LinkedListMerge(test2);
            Console.WriteLine();
            Console.WriteLine("Merged list is:");
            PrintLinkedList(test);
        }

        //Writes a linked list to the console
        static void PrintLinkedList(LinkedList ll)
        {
            Node current = ll.Head;
            do
            {
                Console.Write($"{current.Value} ");
                current = current.Next;
            } while (current.Next != null);
            Console.Write($"{current.Value}\n");
        }
    }
}
