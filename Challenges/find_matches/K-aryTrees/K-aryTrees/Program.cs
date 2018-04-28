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
            Console.WriteLine("We want to find all the nodes in this tree with");
            Console.WriteLine("a value of 7.");
            List<Node<byte>> nodes = FindMatches(tree, 7);
            System.Console.WriteLine("Finding ...");
            System.Console.WriteLine($"{nodes.Count} matches found");
            Tree<byte>.Method render = x => Console.Write($"{x.Value} ");
            foreach (Node<byte> node in nodes)
            {
                Console.Write("Match: ");
                Tree<byte> t = new Tree<byte>(node);
                t.PreOrderTraverse(render);
                Console.WriteLine();
            }
            Console.ReadKey();
            
        }

        public static List<Node<byte>> FindMatches(Tree<byte> tree, byte target)
        {
            List<Node<byte>> output = new List<Node<byte>>();
            Tree<byte>.Method MatchesToCollection = x =>
            {
                if (x.Value == target)
                    output.Add(x);
            };
            tree.PreOrderTraverse(MatchesToCollection);
            return output;
        }
    }
}
