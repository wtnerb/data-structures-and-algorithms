using System;

namespace binary_search
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int BinarySearch (int[] array, int target)
        {
            int min = 0;
            int max = array.Length - 1;
            do
            {
                int pivot = min + (max - min) / 2;
                if (min == pivot)
                {
                    min++;
                    pivot++;
                }
                if (max == pivot)
                {
                    max--;
                    pivot--;
                }
                if (array[pivot] == target)
                {
                    return pivot;
                }
                else if (array[pivot] > target)
                {
                    max = pivot;
                }
                else
                {
                    min = pivot;
                }
            } while (min != max);
            return -1;
        }
    }
}
