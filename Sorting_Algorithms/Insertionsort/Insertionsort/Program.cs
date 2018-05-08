using System;

namespace Insertionsort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 6, 4, 8, 7, 9, 2, 3, 5 };
            Console.WriteLine("Hello World! The starting array is:");
            PrintArray(arr);
            Console.WriteLine("\nThe sorted array is:");
            InsertionSort(arr);
            PrintArray(arr);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        public static void InsertionSort(int[] arr)
        {
            //If it is too small for sorting to be possible, do nothing
            if (arr.Length < 2)
            {
                return;
            }
            else
            {
                //run up the array
                for (int i =  1; i < arr.Length; i++)
                {
                    int j = i;
                    //send a backwards runner, doing swaps until this value is in the correct place
                    while (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        //Combine decrement and swap to a single line
                        arr[--j] = temp;
                        //if it is at the end of the array, break
                        if (j == 0)
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// This prints an array to the console as comma seperated values
        /// </summary>
        /// <param name="arr">Array to be printed</param>
        public static void PrintArray (int[] arr)
        {
            Console.Write($"{arr[0]}");//initialize
            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write($", {arr[i]}");//print each value other than the first after a comma
            }
            Console.WriteLine();//line is over once array is printed
        }
    }
}
