using System;
using System.Collections.Generic;

namespace _08._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> passedQueue = new Queue<string>();

            int countCars = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("end"))
                {
                    Console.WriteLine($"{countCars} cars passed the crossroads.");
                    return; 
                    
                }

                else if (input.Equals("green"))
                {
                    int currentCount = passedQueue.Count > n ? n : passedQueue.Count;

                    for (int i = 0; i < currentCount; i++)
                    {
                        Console.WriteLine($"{passedQueue.Dequeue()} passed!");
                        countCars++;
                    }
                }
                else
                {
                    passedQueue.Enqueue(input);
                }


            }
        }
    }
}
