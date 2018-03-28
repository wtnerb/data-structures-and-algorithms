using System;

namespace ShiftArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] InsertShiftArray(int[] arr, int num)
        {
            int pivot = (1 + arr.Length)/ 2;
            int[] newArr = new int[arr.Length + 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < pivot)
                {
                    newArr[i] = arr[i];
                }
                else if (i > pivot)
                {
                    newArr[i] = arr[i - 1];
                }
                else if (i == pivot)
                {
                    newArr[i] = num;
                }
            }
            return newArr;
        }
    }
}
