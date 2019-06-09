using System;
using System.Linq;

namespace _03._Maximal_Sum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = size[0];
            int cols = size[1];

            int[,] matrix = new int[rows,cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] nums = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];

                }
            }

            int maxSum = Int32.MinValue;
            int sum = 0;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    sum = matrix[row , col] + matrix[row,col+1]
                        + matrix[row, col + 2] + matrix[row + 1, col]
                        + matrix[row +1, col +1] + matrix[row+1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1]
                        + matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxCol = col;
                        maxRow = row;

                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = maxRow; row <= maxRow + 2; row++)
            {
                for (int col = maxCol; col <= maxCol +2; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
