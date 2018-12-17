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
            Max_Heap mh = new Max_Heap(new int[] { 5 });
            Assert.Equal(5, mh.Root.Val);
        }

        [Theory]
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, new int[] { 5, 4, 3, 2, 1 })]
        [InlineData(new int[] { 5, 4, 3, 2, 5 }, new int[] { 5, 5, 3, 2, 4 })]
        [InlineData(new int[] { 5, 4, 3, 6, 5, 2, 8 }, new int[] { 8, 6, 5, 4, 5, 2, 3 })]
        public void CanBuildMaxHeap(int[] arr, int[] maxedArr)
        {
            Max_Heap mh = new Max_Heap(arr);
            var actual = mh.ToArray();
            Assert.True(ArraysMatch(maxedArr, actual));
        }

        [Fact]
        public void CanPutHeapIntoArray()
        {
            int[] startArr = new int[] { 9, 8, 7, 6, 5, 4 };
            Max_Heap mh = new Max_Heap(startArr);
            int[] endArr = mh.ToArray();
            for (int i = 0; i < startArr.Length; i++)
            {
                Assert.Equal(startArr[i], endArr[i]);
            }
            Assert.Equal(startArr.Length, endArr.Length);
        }

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

        [Theory]
        [InlineData(new int[] { 9, 8, 7, 6, 5, 4 }, new int[] { 9, 8, 7, 6, 5, 4 }, "LR")]
        [InlineData(new int[] { 9, 8, 7, 6, 9, 4 }, new int[] { 9, 9, 7, 6, 8, 4 }, "L")]
        public void CanHeapify(int[] startArr, int[] targetArr, string path)
        {
            Max_Heap mh = new Max_Heap(startArr);
            mh.MaxHeapify(Path(mh.Root, path));
            int[] endArr = mh.ToArray();
            Assert.True(ArraysMatch(targetArr, endArr));
        }


        private Node Path(Node root, string path)
        {
            path = path.ToUpper();
            foreach (char c in path)
            {
                if (c == 'L')
                {
                    root = root.Left;
                }
                else if (c == 'R')
                {
                    root = root.Right;
                }
                else
                {
                    throw new Exception("invalid path in test");
                }
            }
            return root;
        }


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
