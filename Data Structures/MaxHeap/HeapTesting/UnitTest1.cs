using System;
using Xunit;

namespace HeapTesting
{
    public class UnitTest1
    {
        [Fact]
        //Proof of life
        public void CanStartHeap()
        {
            Max_Heap mh = new Max_Heap(new int[]{5});
            Assert.True(mh.Root.Val == 5);
        }

        [Fact]
        public void CanBuildHeap(){
            Max_Heap mh = new Max_Heap(new int[]{5, 4, 3, 2, 1});
            Assert.True(mh.Root.Val == 5);
            Assert.True(mh.Root.Left.Val == 4);
            Assert.True(mh.Root.Right.Val == 3);
            Assert.True(mh.Root.Right.Left.Val == 2);
            Assert.True(mh.Root.Right.Right.Val == 1);
        }
    }
}
