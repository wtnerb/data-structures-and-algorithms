using System;
using Xunit;
using ll_find_loop;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindLoop()
        {
            LinkedList ll = new LinkedList(new int[] { 1, 5, 8, -4, 3, 2 });
            Node current = ll.Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = ll.Head.Next;
            Assert.True(ll.HasLoop());
        }

        [Fact]
        public void CanFindNotLoop()
        {
            LinkedList ll = new LinkedList(new int[] { 1, 5, 8, -4, 3, 2 });
            Assert.False(ll.HasLoop());
        }
    }
}
