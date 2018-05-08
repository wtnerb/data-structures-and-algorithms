using System;
using Xunit;
using static Insertionsort.Program;

namespace InsertionTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] {1, 5, 6, 3, 2}, new int[] { 1, 2, 3, 5, 6})]//odd
        [InlineData(new int[] { 1, 5, 3, 2 }, new int[] { 1, 2, 3, 5 })]//even
        [InlineData(new int[] { 1 }, new int[] { 1 })]//single value

        public void Test1(int[] arr, int[] expected)
        {
            InsertionSort(arr);
            Assert.Equal(arr, expected);
        }
    }
}
