using System;
using System.Collections.Generic;

namespace _07._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

            Queue<string> queue = new Queue<string>(input);

            int n = int.Parse(Console.ReadLine());

            while (queue.Count > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    string player = queue.Dequeue();
                    queue.Enqueue(player);
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
                
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
