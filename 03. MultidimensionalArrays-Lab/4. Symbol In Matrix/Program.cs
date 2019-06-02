using System;

namespace _4._Symbol_In_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n,n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowInput = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = rowInput[col];
                }
            }

            var symbol = Console.ReadLine();
            var isSymbol = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col].ToString() == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isSymbol = true;
                        return;
                    }
                }
            }

            if (!isSymbol)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }

        }
    }
}
