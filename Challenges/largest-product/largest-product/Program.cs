using System;

namespace largest_product
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int LargestProduct (int[][] matrix)
        {
            int max = matrix[0][0] * matrix[0][1];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (i < matrix.Length -1 && (matrix[i][j] * matrix[i + 1][j]) > max)
                    {
                        max = matrix[i][j] * matrix[i + 1][j];
                    }
                    if (j < matrix[i].Length - 1 && (matrix[i][j] * matrix[i][j + 1]) > max)
                    {
                        max = matrix[i][j] * matrix[i][j + 1];
                    }
                }
            }
            return max;
        }
    }
}
