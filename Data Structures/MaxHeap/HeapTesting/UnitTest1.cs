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
            Assert.Equal(5, mh.Root.Val);
        }

        [Fact]
        public void CanBuildHeap(){
            Max_Heap mh = new Max_Heap(new int[]{5, 4, 3, 2, 1});
            Assert.Equal(5, mh.Root.Val);
            Assert.Equal(4, mh.Root.Left.Val);
            Assert.Equal(3, mh.Root.Right.Val);
            Assert.Equal(2, mh.Root.Left.Left.Val);
            Assert.Equal(1, mh.Root.Left.Right.Val);
        }

        [Fact]
        public void CanPutHeapIntoArray(){
            int [] startArr = new int[]{9, 8, 7, 6, 5, 4};
            Max_Heap mh = new Max_Heap(startArr);
            int[] endArr = mh.ToArray();
            for (int i = 0; i < startArr.Length; i++)
            {
                Assert.Equal(startArr[i], endArr[i]);
            }
            Assert.Equal(startArr.Length, endArr.Length);
        }
    }
}
