using System;
using System.Linq;

namespace _02._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] arr = new int[dimensions[0], dimensions[1]];


            for (int row = 0; row < arr.GetLength(0); row++)
            {
                int[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    arr[row, col] = tokens[col];
                }
            }

            for (int col = 0; col < arr.GetLength(1); col++)
            {
                int sum = 0;

                for (int row = 0; row < arr.GetLength(0); row++)
                {
                    sum += arr[row, col];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
