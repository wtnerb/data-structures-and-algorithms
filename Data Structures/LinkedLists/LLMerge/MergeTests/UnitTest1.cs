using System;
using Xunit;
using LLMerge;

namespace MergeTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Checks that even "indecies" are as expected
        /// </summary>
        [Fact]
        public void CanMerge()
        {
            int[] arr1 = { 1, 3, 5 };
            int[] arr2 = { 2, 4 };
            LinkedList test = new LinkedList(arr1);
            LinkedList test2 = new LinkedList(arr2);
            test.LinkedListMerge(test2);
            Assert.Equal(2, test.Item(1).Value);
        }

        [Fact]
        public void CanMerge2()
        {
            int[] arr1 = { 1, 3, 5 };
            int[] arr2 = { 2, 4 };
            LinkedList test = new LinkedList(arr1);
            LinkedList test2 = new LinkedList(arr2);
            test.LinkedListMerge(test2);
            Assert.Equal(3, test.Item(2).Value);
        }

        [Fact]
        public void CanMergeHandlesEnd()
        {
            int[] arr1 = { 1, 3, 5 };
            int[] arr2 = { 2, 4 };
            LinkedList test = new LinkedList(arr1);
            LinkedList test2 = new LinkedList(arr2);
            test.LinkedListMerge(test2);
            Assert.Equal(4, test.Item(3).Value);
        }

    }
}
