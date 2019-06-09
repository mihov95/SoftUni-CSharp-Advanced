using System;
using System.Linq;

namespace _2._2x2_Squares_in_Matrix
{
    class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int cols = size[1];

            char [,] matrix = new char[rows,cols];

            for (int row = 0; row < matrix.GetLength(0) ; row++)
            {
                char[] inputData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputData[col];
                }

            }

            int matrixSquares = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char currSymbol = matrix[row, col];

                    if (currSymbol == matrix[row, col + 1]
                        && currSymbol == matrix[row + 1, col]
                        && currSymbol == matrix[row + 1, col + 1])
                    {
                        matrixSquares++;
                    }
                }
            }

            Console.WriteLine(matrixSquares);

        }
    }
}
