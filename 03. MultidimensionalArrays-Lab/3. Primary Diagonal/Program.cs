using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int row = 0; row < size; row++)
            {
                int[] nums = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    if (row == col)
                    {
                        sum += nums[col];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
