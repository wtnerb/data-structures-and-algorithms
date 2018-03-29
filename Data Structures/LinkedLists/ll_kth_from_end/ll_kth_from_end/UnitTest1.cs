using System;
using Xunit;
using kth_from_end;

namespace ll_kth_from_end
{
    public class UnitTest1
    {
        [Fact]
        //[InlineData(new int[] { 1, 5, 3, 6, 2, 9, 11 }, 6)]
        public void CanFindZerothFromEnd()
        {
            LinkedList l = new LinkedList(new int[] { 1, 5, 3, 6, 7 });
            Node expect = new Node(1);
            Assert.Equal(expect, l.KthFromEnd(0));
        }

        [Fact]
        public void CanFindThirdFromEnd()
        {
            LinkedList l = new LinkedList(new int[] { 1, 5, 3, 6, 2, 9, 11 });
            LinkedList ex = new LinkedList(new int[] { 1, 5, 3 });
            Node expect = ex.Head;
            Assert.Equal(expect, l.KthFromEnd(2));
        }
    }
}
