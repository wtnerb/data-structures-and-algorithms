using System;
using System.Collections.Generic;

namespace mergesort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\nPerforming a merge sort. The result is ... ");
            int[] arr = { 1, 5, 9, 8, 4, 3, 7 };
            foreach (int n in MergeSort(arr))
            {
                Console.Write($"{n}, ");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Sorts an array of ints
        /// </summary>
        /// <param name="arr">array of ints to be sorted</param>
        /// <returns>array sorted from smallest to largest</returns>
        public static int[] MergeSort (int[] arr)
        {
            //Stopping condition for recursive call
            if (arr.Length == 1)
                return arr;
            //Manually slicing
            int[] first = new int[(arr.Length + 1) / 2];
            int[] last = new int[arr.Length / 2];
            Array.Copy(arr, first, first.Length);
            Array.Copy(arr, first.Length, last, 0, last.Length);

            //Call recursively on each slice
            first = MergeSort(first);
            last = MergeSort(last);

            //Actually merge together, with three pointers (would be easier with pop)
            int f = 0;
            int l = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                //While both have content, compare and merge
                //merge onto starting arr
                if (first.Length > f && last.Length > l)
                {
                    if (first[f] < last[l])
                    {
                        arr[i] = first[f];
                        f++;
                    }
                    else
                    {
                        arr[i] = last[l];
                        l++;
                    }
                }
                //Once one is empty, just copy and and increment the non-empty
                else if (first.Length > f)
                {
                    arr[i] = first[f];
                    f++;
                }
                else
                {
                    arr[i] = last[l];
                    l++;
                }
            }
            //After doing the merge, return merged, sorted list
            return arr;
        }
    }
}
