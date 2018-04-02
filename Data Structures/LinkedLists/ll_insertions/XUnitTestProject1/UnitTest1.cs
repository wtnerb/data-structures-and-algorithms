using System;
using Xunit;
using ll_insertions;
using static ll_insertions.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanBuildLL()
        {
            int[] initializer = new int[] { 1, 8, 5, -4 };
            LinkedList ll = new LinkedList(initializer);
            bool status = true;
            byte count = 0;
            Node current = ll.Head;
            while (current != null) // compares every value in ll against array
            {
                if (current.Value != initializer[count])
                {
                    status = false;
                }
                current = current.Next;
                count++;
            }
            if (count != initializer.Length)
            {
                status = false; //checks if array is longer than ll
            }
            Assert.True(status);
        }

        [Theory]
        [InlineData(true, new int[] { 1, 8, 5, -4 })]
        [InlineData(false, new int[] { 1, 8, 5, 5 })]
        [InlineData(false, new int[] { -1, 8, 5, -4 })]
        [InlineData(false, new int[] { 1, 8, 5, -4, 5 })]
        public void CanCompareLL(bool expect, int[] comparison)
        {
            int[] initializer = new int[] { 1, 8, 5, -4 };
            LinkedList ll = new LinkedList(initializer);
            LinkedList ll2 = new LinkedList(comparison);
            Assert.Equal(expect, CompareLL(ll, ll2));
        }

        [Fact]
        public void CanAppendNode()
        {
            int[] comparison = new int[] { 1, 8, 5, -4, 5 };
            int[] initializer = new int[] { 1, 8, 5, -4 };
            LinkedList ll = new LinkedList(initializer);
            LinkedList ll2 = new LinkedList(comparison);
            Assert.True(CompareLL(ll2, Append(ll, 5)));
        }

        [Fact]
        public void CanInsertAfter()
        {
            int[] comparison = new int[] { 1, 8, -5, 5, -4};
            int[] initializer = new int[] { 1, 8, 5, -4 };
            LinkedList ll = new LinkedList(initializer);
            LinkedList ll2 = new LinkedList(comparison);
            Assert.True(CompareLL(ll2, InsertAfter(ll, 8, -5)));
        }

        [Fact]
        public void CanInsertBefore()
        {
            int[] comparison = new int[] { 1, 8, -5, 5, -4 };
            int[] initializer = new int[] { 1, 8, 5, -4 };
            LinkedList ll = new LinkedList(initializer);
            LinkedList ll2 = new LinkedList(comparison);
            Assert.True(CompareLL(ll2, InsertBefore(ll, 5, -5)));
        }



    }
}
