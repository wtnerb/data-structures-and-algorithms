using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversearray
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is repetitive. I'd normally look into making an array of test arrays to loop across, but had spent enough time.
            int[] example1 = { 1, 2, 3, 4, 5 };
            int[] example2 = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41,
                43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107,
                109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199 };
            int[] example3 = { 1, -2 };
            TestReverses(example1);
            TestReverses(example2);
            TestReverses(example3);
            Console.ReadLine();
        }

        static void TestReverses(int[] example)
        {
            ShowArr(example);
            Console.WriteLine("simple reverse:");
            ShowArr(SimpleReverse(example));
            Console.WriteLine("in place reverse:");
            InPlaceReverse(example);
            ShowArr(example);
        }

        static void InPlaceReverse(int[] nums)
        {
            for (int i = 0; i < nums.Length / 2; i++)
            {
                int temp = nums[i];
                nums[i] = nums[nums.Length - i - 1];
                nums[nums.Length - i - 1] = temp;
            }
        }

        static int[] SimpleReverse(int[] nums)
        {
            int[] output = new int[nums.Length];
            for (
                int i = 0; i <= nums.Length - 1; i++)
            {
                output[i] = nums[nums.Length - 1 - i];
            }
            return output;
        }

        static void ShowArr(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num);
            }
            Console.WriteLine("");
        }
    }
}