using System;
using Xunit;
using Binary_Tree;
using FizzBuzzTree;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanFizzBuzzTree()
        {
            BinaryTree tree = new BinaryTree
            {
                Root = new Node() { Value = "6", Left = null, Right = null }
            };
            BinaryTree.Delegate l = x =>
            {
                Console.Write(x.Value + " ");
            };
            string[] data = new string[] { "4", "300", "-5", "5", "25", "443" };
            foreach (string n in data)
            {
                tree.Add(n);
            }
            tree = Program.FizzBuzz(tree);
            //Expect results from in order tree traversal
            string[] expected = { "buzz", "4", "buzz", "fizz", "buzz", "fizzbuzz", "443" };
            //Placeholder for actual results of in order tree traversal
            string[] actual = new string[7];

            //Set up recursive traverse
            int count = 0;
            BinaryTree.Delegate actualize = x => {
                actual[count] = x.Value;
                count++;
            };
            //Traverse tree and put each value, in order, into the 'actual' array of strings
            tree.InorderTraverse(actualize);

            //Check each value of actual and expected for equality. No surprises allowed.
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }

        }
    }
}
