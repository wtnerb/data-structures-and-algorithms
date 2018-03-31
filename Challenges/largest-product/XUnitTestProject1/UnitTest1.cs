using System;
using Xunit;
using static largest_product.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanBottomRightCorner()
        {
            int[][] m = new int[][] { new int[] { 1, 3 }, new int[] { 3, 5 } };
            Assert.Equal(15, LargestProduct(m));
        }

        [Fact]
        public void CanBottomLeftCorner()
        {
            int[][] m = new int[][] { new int[] { 6, 3, 4 }, new int[] { 22, 3, 5 } };
            Assert.Equal(132, LargestProduct(m));
        }

        [Fact]
        //This test specifically has every number in it a prime number (and 1)
        //That can be useful for determining which incorrect match occured.
        public void CanTopRightCorner()
        {
            int[][] m = new int[][] { new int[] { 1, 3, 19 }, new int[] { 5, 7, 23 }, new int[] { 11, 13, 17 } };
            Assert.Equal(19*23, LargestProduct(m));
        }

        [Fact]
        public void CanTopLeftCorner()
        {
            int[][] m = new int[][] { new int[] { 4, 3, 5 }, new int[] { 22, 3, 5 }, new int[] { 1, 1, 1 } };
            Assert.Equal(88, LargestProduct(m));
        }
    }
}
