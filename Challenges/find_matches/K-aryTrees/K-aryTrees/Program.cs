using System;
using System.Collections.Generic;

namespace K_aryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The file will build and manipulate this tree:\n" +
                "        6         \n" +
                "      /   \\       \n" +
                "     3      7      \n" +
                "   / | \\  / | \\  \n" +
                "  5 4  2  1  7  9");
            Node<byte> n = new Node<byte>(6);//test ctor
            Tree<byte> tree = new Tree<byte>(n);//test tree ctor and node ctor
            Node<byte> left = new Node<byte>(3, new byte[] { 5, 4, 2 });//test ctor
            tree.Root.Children.Add(left);
            tree.Add(6, 7);//add works
            tree.Add(7, 1);//add working means breadth first works
            tree.Add(7, 7);//duplicate val in correct place
            tree.Add(7, 9);//Adds new to highest duplicate, adds only once
            Console.WriteLine("Pre Order traverse: ");
            Tree<byte>.Method render = x => Console.Write($"{x.Value} ");
            tree.PreOrderTraverse(render);
            Console.ReadKey();
            
        }

        public IEnumerable<Node<int>> FindMatches(Tree<int> tree, int target)
        {
            new List<Node<int>> output
            tree.Method MatchesToCollection = x => 
                if (x.Value == target)
                    output.Add(x);
            tree.PreOrderTraverse(MatchesToCollection);
            return output;
        }
    }
}
