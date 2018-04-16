using System;
using Xunit;
using Binary_Tree;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanStartTree()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node() { Value = 5 };
            Assert.Equal(5, tree.Root.Value);
            Assert.Null(tree.Root.Right);
            Assert.Null(tree.Root.Left);
        }

        [Theory]
        [InlineData(6, new sbyte[] { })]
        [InlineData(4, new sbyte[] { -1 })]
        [InlineData(-5, new sbyte[] { -1, -1 })]
        [InlineData(443, new sbyte[] { 1, 1 })]
        //In the course, start at root. -1 means go left, 1 means go right. End of course means check the value at that node.
        public void CanAddToTree(int expect, sbyte[] course)
        {
            //Creates tree and does the adding
            BinaryTree tree = new BinaryTree
            {
                Root = new Node() { Value = 6, Left = null, Right = null }
            };
            int[] data = new int[] { 4, 300, -5, 5, 25, 443 };
            foreach (int n in data)
            {
                tree.Add(n);
            }

            //Navigate to the node by following the given course. Will check that node has expected value.
            Node current = tree.Root;
            foreach(sbyte direction in course)
            {
                if (direction == -1)
                {
                    current = current.Left;
                }
                else if (direction == 1)
                {
                    current = current.Right;
                }
            }
            Assert.Equal(expect, current.Value);
        }

        [Fact]
        public void CanTraverseInOrder()
        {
            BinaryTree tree = new BinaryTree
            {
                Root = new Node() { Value = 6, Left = null, Right = null }
            };
            int[] data = new int[] { 4, 300, -5, 5, 25, 443 };
            foreach (int n in data)
            {
                tree.Add(n);
            }
            int counter = 0;
            int[] expect = new int[] { -5, 4, 5, 6, 25, 300, 443 };
            int[] find = new int[data.Length + 1];
            BinaryTree.Delegate del = x =>
            {
                find[counter] = x.Value;
                counter++;
            };

            tree.InorderTraverse(del);

            for (int i = 0; i < find.Length; i++)
            {
                Assert.Equal(find[i], expect[i]);
            }
            Assert.Equal(find.Length, expect.Length);
        }

        [Fact]
        public void CanTraversePreOrder()
        {
            BinaryTree tree = new BinaryTree
            {
                Root = new Node() { Value = 6, Left = null, Right = null }
            };
            int[] data = new int[] { 4, 300, -5, 5, 25, 443 };
            foreach (int n in data)
            {
                tree.Add(n);
            }
            int counter = 0;
            int[] expect = new int[] { 6, 4, -5, 5, 300, 25, 443 };
            int[] find = new int[data.Length + 1];
            BinaryTree.Delegate del = x =>
            {
                find[counter] = x.Value;
                counter++;
            };

            tree.PreorderTraverse(del);

            for (int i = 0; i < find.Length; i++)
            {
                Assert.Equal(find[i], expect[i]);
            }
            Assert.Equal(find.Length, expect.Length);
        }

        [Fact]
        public void CanTraversePostOrder()
        {
            BinaryTree tree = new BinaryTree
            {
                Root = new Node() { Value = 6, Left = null, Right = null }
            };
            int[] data = new int[] { 4, 300, -5, 5, 25, 443 };
            foreach (int n in data)
            {
                tree.Add(n);
            }
            int counter = 0;
            int[] expect = new int[] { -5, 5, 4, 25, 443, 300, 6 };
            int[] find = new int[data.Length + 1];
            BinaryTree.Delegate del = x =>
            {
                find[counter] = x.Value;
                counter++;
            };

            tree.PostorderTraverse(del);

            for (int i = 0; i < find.Length; i++)
            {
                Assert.Equal(find[i], expect[i]);
            }
            Assert.Equal(find.Length, expect.Length);
        }
    }
}
