using System;
using Xunit;
using static mergesort.Program;
namespace MergeTest
{
    public class UnitTest1
    {
        [Theory]
        //even number of nums
        [InlineData(new int[] { 1, 5, 3, 7, 4, 2 }, new int[] { 1, 2, 3, 4, 5, 7 })]
        //odd number of nums
        [InlineData(new int[] { 1, 5, 3, 7, 4, 2, 6 }, new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        //nums like 0 and -2
        [InlineData(new int[] { 1, 5, 3, 7, 4, 2, 6, 0, -2 }, new int[] { -2, 0, 1, 2, 3, 4, 5, 6, 7 })]
        public void Test1(int[] unsorted, int[] sorted)
        {
            int[] sort = MergeSort(unsorted);
            Assert.Equal(sorted, sort);
        }
    }
}
