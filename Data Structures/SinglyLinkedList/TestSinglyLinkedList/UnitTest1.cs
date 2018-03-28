using System;
using Xunit;
using SinglyLinkedList;

namespace TestSinglyLinkedList
{
    public class UnitTest1
    {
        [Fact]
        public void CanStartList()
        {
            LinkedList l = new LinkedList(5);
            Assert.Equal(5, l.Head.Value);
        }

        [Theory]
        [InlineData(new int[] {1, 5, 3, 6, 7}, 5)]
        [InlineData(new int[] { 1, 5, 3, 6, 2, 9, 11 }, 7)]
        public void CanAddToList(int[] arr, int len)
        {
            LinkedList l = new LinkedList(arr);
            int linkedListlLength = 1;
            Node current = l.Head;
            while (current.Next != null)
            {
                linkedListlLength++;
                current = current.Next;
            }
            Assert.Equal(len, linkedListlLength);
        }

        [Theory]
        [InlineData(new int[] { 1, 5, 3, 6, 7 }, 5, 3)]
        [InlineData(new int[] { 1, 5, 3, 6, 2, 9, 11 }, 7, -1)]
        [InlineData(new int[] { 1, 5, 3, 6, 2, 9, 11 }, 9, 1)]
        public void CanFindInList(int[] arr, int target, int result)
        {
            LinkedList l = new LinkedList(arr);
            Assert.Equal(result, l.Find(target));
        }



    }
}
