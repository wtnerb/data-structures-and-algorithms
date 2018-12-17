using System;
using Binary_Tree;

namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, building a simple tree.");
            Console.WriteLine(
                "     |6| -- the root\n" +
                "     /  \\ \n" +
                "  |4|   |300| \n" +
                "  / \\     /  \\ \n" +
                "|-5| |5| |25| |443| ");
            BinaryTree<string> tree = new BinaryTree<string>
            {
                Root = new Node<string>() { Value = "6", Left = null, Right = null }
            };
            BinaryTree<string>.Delegate l = x =>
            {
                Console.Write(x.Value + " ");
            };
            string[] data = new string[] { "4", "300", "-5", "5", "25", "443" };
            foreach (string n in data)
            {
                tree.Add(n);
            }

            Console.WriteLine("The new tree looks like:");
            tree = FizzBuzz(tree);
            BinaryTree<string>.Delegate print = x => Console.Write($"{x.Value} ");
            tree.InorderTraverse(print);
            Console.WriteLine();
            Console.WriteLine("It should look like\n" +
                "buzz 4 buzz fizz buzz fizzbuzz 443");
            Console.ReadKey();
        }

        public static BinaryTree<string> FizzBuzz (BinaryTree<string> tree)
        {
            //Because my traversal methods use delegates, I only have to write a FizzBuzz delegate
            BinaryTree<string>.Delegate fizzBuzz = x =>
            {
                if (int.Parse(x.Value) % 15 == 0)
                {
                    x.Value = "fizzbuzz";
                }
                else if (int.Parse(x.Value) % 5 == 0)
                {
                    x.Value = "buzz";
                }
                else if (int.Parse(x.Value) % 3 == 0)
                {
                    x.Value = "fizz";
                }
            };

            tree.InorderTraverse(fizzBuzz);
            return tree;
        }
    }
}
