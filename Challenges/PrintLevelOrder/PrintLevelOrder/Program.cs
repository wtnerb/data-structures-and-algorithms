using System;
using System.Collections.Generic;
using System.Text;
using K_aryTrees;

namespace PrintLevelOrder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node<char> root = new Node<char>('A', new char[] { 'B', 'C', 'D', 'E', 'F', 'G' });
            Tree<char> tree = new Tree<char>(root);
            tree.Add('B', 'H');
            tree.Add('B', 'I');
            tree.Add('B', 'J');
            tree.Add('E', 'K');
            tree.Add('E', 'L');
            tree.Add('G', 'M');
            tree.Add('H', 'N');
            tree.Add('H', 'O');
            tree.Add('K', 'P');
            tree.Add('L', 'Q');
            Console.WriteLine("If tree is built correctly, a breadth first traverse should render chars in alphebetical order from A-Q without skipping");
            Tree<char>.Method renderInLine = n => Console.Write($"{n.Value} ");
            tree.BreadthFirstTraverse(renderInLine);

            Console.WriteLine(PrintLevelOrder(tree));

            Console.ReadKey();
        }

        public static string PrintLevelOrder(Tree<char> tree)
        {
            Queue<Node<char>> q = new Queue<Node<char>>();
            //By making sentinel a Node of value newline, the newline printing each time sentinel is found is automated
            Node<char> sentinel = new Node<char> ('\n');
            StringBuilder sb = new StringBuilder();
            q.Enqueue(tree.Root);
            q.Enqueue(sentinel);
            Console.WriteLine("Begining to print level order:");
            while (q.TryDequeue(out Node<char> current))
            {
                sb.Append($"{current.Value} ");
                foreach (Node<char> child in current.Children)
                {
                    q.Enqueue(child);
                }
                if (current == sentinel)//Equality only occurs if same reference as placeholder
                {
                    try
                    {
                        q.Peek();
                        q.Enqueue(sentinel);
                    }
                    catch
                    {}
                }
            }
            Console.WriteLine("built string");
            return sb.ToString();
        }
    }
}
