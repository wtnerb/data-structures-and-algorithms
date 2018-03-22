using System;
using Xunit;
using Program;

namespace Binary_tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(-1, 8)]
        [InlineData(0, 1)]
        [InlineData(2, 4)]
        [InlineData(6, 9)]
        [InlineData(1, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 6)]
        [InlineData(5, 7)]
        public void CanSearchOdd(int expected, int target)
        {
            int[] testArr = { 1, 3, 4, 5, 6, 7, 9 };
            Assert.Equal(expected, Program.BinarySearch(testArr, target));
        }
    }
}
