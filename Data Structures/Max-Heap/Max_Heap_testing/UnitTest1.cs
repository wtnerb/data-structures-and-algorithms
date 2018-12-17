using System;
using Xunit;

namespace HeapTesting
{
    public class UnitTest1
    {
        // Checks that:
        [Theory]
        // A heap can be built
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, new int[] { 5, 4, 3, 2, 1 })]
        // Some basic maxing does occur, handles single child
        [InlineData(new int[] { 5, 4, 3, 2, 5, 3 }, new int[] { 5, 5, 3, 2, 4, 3 })]
        // A more thorough testing that the maxing process works as intended
        [InlineData(new int[] { 5, 4, 3, 6, 5, 2, 8 }, new int[] { 8, 6, 5, 4, 5, 2, 3 })]
        public void CanBuildMaxHeap(int[] arr, int[] maxedArr)
        {
            Max_Heap mh = new Max_Heap(arr);
            var actual = mh.ToArray();
            Assert.True(ArraysMatch(maxedArr, actual));
        }

        // Checks tooling that a max heap can be turned into an array
        [Fact]
        public void CanPutHeapIntoArray()
        {
            int[] startArr = new int[] { 9, 8, 7, 6, 5, 4 };
            Max_Heap mh = new Max_Heap(startArr);
            int[] endArr = mh.ToArray();
            Assert.Equal(startArr.Length, endArr.Length);
            for (int i = 0; i < startArr.Length; i++)
            {
                Assert.Equal(startArr[i], endArr[i]);
            }
        }

        // checks that arrays match tooling works, is essential for other tests
        [Theory]
        [InlineData(new int[] { 9, 8, 7, 6, 5, 4 }, new int[] { 9, 8, 7, 6, 5, 4 }, true)]
        [InlineData(new int[] { 9, 8, 7, 6, 9, 4 }, new int[] { 9, 9, 7, 6, 8, 4 }, false)]
        [InlineData(new int[] { 9, 8, 7, 6, 9, 4 }, new int[] { 10, 8, 7, 6, 5, 4 }, false)]
        [InlineData(new int[] { 9, 8, 7, 6, 9, 4 }, new int[] { 9, 8, 7, 6, 5, 2 }, false)]
        public void ArraysMatchVerification(int[] start, int[] finish, bool expect)
        {
            bool actual = ArraysMatch(start, finish);
            Assert.Equal(expect, actual);
        }

        // Helper function that checks arrays value by value for equivalence
        private bool ArraysMatch(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                Console.WriteLine($"arrays have different lengths {arr1.Length} and {arr2.Length}");
                return false;
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"arrays have different values at index {i}: {arr1[i]} {arr2[i]}");
                    return false;
                }
            }
            return true;
        }
    }
}
