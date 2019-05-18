using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < input.Length; i++)
            {
                queue.Enqueue(input[i]);
                if (input[i] % 2 == 0)
                {

                    if (i == input.Length - 1)
                    {
                        Console.Write($"{queue.Peek()}");
                    }
                    else
                    {
                        Console.Write($"{queue.Peek()}, ");

                    }

                }

                queue.Dequeue();
            }
        }
    }
}
