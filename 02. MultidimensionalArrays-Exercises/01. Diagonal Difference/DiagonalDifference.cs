using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Diagonal_Difference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] matrix = new int[size][];

            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            int primarySum = 0;

            for (int row = 0; row < size; row++)
            {
                primarySum += matrix[row][row];
            }

            int secondarySum = 0;

            for (int row = 0, col = size - 1; row < size; row++, col--)
            {
                secondarySum += matrix[row][col];
            }

            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}
