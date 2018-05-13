using System;
using Xunit;
using static QuickSort.Program;

namespace Testing
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, -1, -2, -3, -4, -5, -6, -7, -8, -9})]
        [InlineData(new int[] { 5, 5, 5, 5, 4, 4, 4, 4, 4, 3, 3, 3, 3, 3})]
        [InlineData(new int[] { 1, 2, 3, 4, 5})]
        public void CanSort(int[] arr)
        {
            Qs(arr);
            Assert.True(IsInOrder(arr));
        }

        public bool IsInOrder(int[] arr)
        {
            int prev = arr[0];
            foreach(int val in arr)
            {
                if (val < prev)
                    return false;
                prev = val;
            }
            return true;
        }
    }
}
