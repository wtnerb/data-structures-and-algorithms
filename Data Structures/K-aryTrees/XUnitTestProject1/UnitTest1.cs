using System;
using Xunit;
using K_aryTrees;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanMakeNode()
        {
            Assert.NotNull(new Node<string>());
            Node<int> node2 = new Node<int>();
            Assert.NotNull(node2.Children);
        }

        [Fact]
        public void CanMakeNodeWithArray()
        {
            byte[] arr = new byte[] { 1, 5, 3, 6, 7, 9 };
            Node<byte> n = new Node<byte>(4, arr);
            Assert.Equal(4, n.Value);
            byte i = 0;
            foreach (Node<byte> node in n.Children)
            {
                Assert.Equal(node.Value, arr[i]);
                i++;
            }
        }

        [Fact]
        public void CanMakeTree()
        {
            Tree<int> t = new Tree<int>(5);
            Assert.NotNull(t.Root);
        }

        [Fact]
        public void CanMakeTreeWithNode()
        {
            byte[] arr = new byte[] { 1, 5, 3, 6, 7, 9 };
            Node<byte> n = new Node<byte>(4, arr);
            Tree<byte> t = new Tree<byte>(n);
            Assert.NotNull(t.Root);
        }

        [Fact]
        public void CanTraverseBreadthFirst()
        {
            byte[] arr = new byte[] { 1, 5, 3, 6, 7, 9 };
            Node<byte> n = new Node<byte>(4, arr);
            Tree<byte> t = new Tree<byte>(n);
            foreach (Node<byte> node in t.Root.Children)
            {
                node.Children.Add(new Node<byte>((byte)(node.Value - 1)));
                node.Children.Add(new Node<byte>((byte)(node.Value + 2)));
            }

            byte[] expected = new byte[] { 4, 1, 5, 3, 6, 7, 9, 0, 3, 4, 7, 2, 5, 5, 8, 6, 9, 8, 11 };
            byte count = 0;
            Tree<byte>.Method iterAssert = node =>
            {
                Assert.Equal(expected[count], node.Value);
                count++;
            };
            t.BreadthFirstTraverse(iterAssert);
        }

        [Fact]
        public void CanAdd()
        {
            byte[] arr = new byte[] { 1, 5, 3, 6, 7, 9 };
            Node<byte> n = new Node<byte>(4, arr);
            Tree<byte> t = new Tree<byte>(n);
            t.Add(5, 5);
            t.Add(5, 6);
            t.Add(5, 4);
            byte[] expected = new byte[] { 4, 1, 5, 3, 6, 7, 9, 5, 6, 4 };
            byte count = 0;
            Tree<byte>.Method iterAssert = node =>
            {
                Assert.Equal(expected[count], node.Value);
                count++;
            };
            t.BreadthFirstTraverse(iterAssert);
        }
    }
}
