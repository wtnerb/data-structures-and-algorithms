using System;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] test1 = new int[] { 5, 4, 2, 7, 9, 5, 6 };
            int[] test2 = new int[] { 3, 4, 1, 2, 9 };
            int[] test3 = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            Qs(test1);
            RenderArray(test1);
            Qs(test2);
            RenderArray(test2);
            Qs(test3);
            RenderArray(test3);
            Console.ReadKey();
        }

        public static void Qs (int[] arr)
        {
            Qs(arr, 0, arr.Length - 1);
        }

        static void Qs (int[] arr, int min, int max)
        {
            //Stopping condition for recursion
            if (min >= max)
                return;

            //min and max will be used in recursive call.
            //right and left are working values tracing the sort
            int left = min;
            int right = max;

            //pivot chosen in center. More performant than choosing edge
            //in cases where list has lots of duplicates or is already sorted
            int pivot = (max - min) / 2 + min;

            //The sort itself
            while (left < pivot)
            {
                if (arr[left] > arr[pivot])
                {
                    //Try to find pair of values on left and right that are on wrong side of pivot.
                    while (arr[right] > arr[pivot] && right > pivot)
                        right--;
                    if (right > pivot)//only happens if arr[right] > arr[pivot]
                    {
                        //A value on the left and the right has been found. Swap and increment
                        Swap(right--, left++);
                    }
                    else
                    {
                        Swap(left, pivot - 1); // bring the misplaced value next to pivot
                        Swap(pivot - 1, pivot--);//swap with the pivot
                    }
                }
                else
                    left++;
            }

            while (right > pivot)
            {
                if (arr[right] <= arr[pivot])
                {
                    Swap(right, pivot + 1);
                    Swap(pivot + 1, pivot++);
                    
                }
                else
                {
                    right--;
                }
            }

            //Lots of swapping happens. Made entirely local so no need to pass in the array
            void Swap (int firstIndex, int secondIndex)
            {
                int temp = arr[firstIndex];
                arr[firstIndex] = arr[secondIndex];
                arr[secondIndex] = temp;
            }

            Qs(arr, min, pivot - 1);
            Qs(arr, pivot + 1, max);
        }

        private static void RenderArray (int[] arr)
        {
            Console.Write(arr[0]);
            for (int i = 1; i < arr.Length; i++)
                Console.Write($", {arr[i]}");
            Console.WriteLine();
        }
    }
}
