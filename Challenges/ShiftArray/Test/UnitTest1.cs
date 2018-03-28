using System;
using Xunit;
using ShiftArray;

namespace Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData (new int[] { 1, 3, 5, 7 }, new int[] { 1, 3, 7 }, 5)]
        [InlineData(new int[] { 1, 3, 5, 7, 9 }, new int[] { 1, 3, 7, 9 }, 5)]

        public void CanInsertShift(int[] expected, int[] array, int add)
        {
            Assert.Equal(expected, Program.InsertShiftArray(array, add));
        }
    }
}
