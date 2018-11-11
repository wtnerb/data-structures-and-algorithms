using System;
using Xunit;

namespace HeapTesting
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Max_Heap mh = new Max_Heap(new int[]{5});
            Assert.True(mh.Root.Val == 5);
        }
    }
}
