using System;
using System.Linq;

namespace _05._Square_With_Maximum_Sum
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
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    arr[row, col] = tokens[col];
                }
            }

            int maxSum = int.MinValue;
            int selectedRow = -1;
            int selectedCol = -1;


            for (int row = 0; row < arr.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < arr.GetLength(1) - 1; col++)
                {
                    int sum = arr[row, col]
                        + arr[row, col + 1]
                        + arr[row + 1, col]
                        + arr[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        selectedCol = col;
                        selectedRow = row;
                    }
                }
            }

            Console.WriteLine($"{arr[selectedRow, selectedCol]} " +
                $"{arr[selectedRow, selectedCol + 1]}\n" +
                $"{arr[selectedRow + 1, selectedCol]} " +
                $"{arr[selectedRow + 1, selectedCol + 1]}\n{maxSum}");

        }
    }
}
