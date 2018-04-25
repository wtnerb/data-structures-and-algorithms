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
            //prove that the improved default ctor works
            Assert.NotNull(new Node<string>());
            Node<int> node2 = new Node<int>();
            Assert.NotNull(node2.Children);
        }

        [Fact]
        public void CanMakeNodeWithArray()
        {
            //prove that ctor with array of child values works
            byte[] arr = new byte[] { 1, 5, 3, 6, 7, 9 };
            Node<byte> n = new Node<byte>(4, arr);

            //assert
            Assert.Equal(4, n.Value);// node value is right
            byte i = 0;
            foreach (Node<byte> node in n.Children)
            {
                Assert.Equal(node.Value, arr[i]);//child nodes are right
                i++;
            }
            Assert.Equal(arr.Length, i);//length of chilren and initializer match
        }

        [Fact]
        public void CanMakeTree()
        {
            //ctor makes a thing
            Tree<int> t = new Tree<int>(5);
            Assert.NotNull(t.Root);
        }

        [Fact]
        public void CanMakeTreeWithNode()
        {
            //other ctor makes a thing
            byte[] arr = new byte[] { 1, 5, 3, 6, 7, 9 };
            Node<byte> n = new Node<byte>(4, arr);
            Tree<byte> t = new Tree<byte>(n);
            Assert.NotNull(t.Root);
        }

        [Fact]
        public void CanTraverseBreadthFirst()
        {
            //traversing breadth first will get expected results
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

            //Assert
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
            //When using Add method, resulting tree is as expected
            byte[] arr = new byte[] { 11, 5, 13, 16, 17};
            Node<byte> n = new Node<byte>(14, arr);
            Tree<byte> t = new Tree<byte>(n);
            t.Add(5, 5); // can add
            t.Add(5, 6); // will add to correct duplicate
            t.Add(5, 4); // will add to end of child list
            byte[] expected = new byte[] { 14, 11, 5, 13, 16, 17, 5, 6, 4 };
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
