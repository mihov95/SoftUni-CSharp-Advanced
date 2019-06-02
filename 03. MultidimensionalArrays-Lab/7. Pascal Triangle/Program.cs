using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[size][];

            int cols = 1;

            for (int i = 0; i < size; i++)
            {
                jaggedArr[i] = new int[cols];
                jaggedArr[i][0] = 1;
                jaggedArr[i][cols - 1] = 1;

                if (cols > 2)
                {
                    int[] previousRow = jaggedArr[i - 1];

                    for (int j = 0; j < cols - 1; j++)
                    {
                        jaggedArr[i][j] = previousRow[j] + previousRow[j - 1];
                    }
                }

                cols++;
            }

            foreach (var item in jaggedArr)
            {
                Console.WriteLine(string.Join(' ', item));
            }

        }
    }
}
