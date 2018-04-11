using System;

namespace BinaryTree
{
    class Program
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
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node() { Value = 6, Left = null, Right = null};
            int[] data = new int[] { 4, 300, -5, 5, 25, 443 };
            foreach (int n in data)
            {
                tree.Add(n);
            }
            Console.WriteLine("Should be built. Testing: print in order:");
            tree.InorderTraverse();
            Console.WriteLine("should be built. Testing, print using post order");
            tree.PostorderTraverse();
            Console.WriteLine("Should be built. Testing, print using pre order");
            tree.PreorderTraverse();
            Console.ReadKey();

        }
    }
}
