using System;
using System.Linq;

namespace _01._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().
                Split(", ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            int[,] arr = new int[dimensions[0],dimensions[1]];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int[] tokens = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = tokens[j];
                }
            }

            Console.WriteLine(arr.GetLength(0));
            Console.WriteLine(arr.GetLength(1));

            int sum = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
            }

            Console.WriteLine(sum);


        }
    }
}
