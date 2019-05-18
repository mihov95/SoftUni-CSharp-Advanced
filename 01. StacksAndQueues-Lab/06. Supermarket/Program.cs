using System;
using System.Collections.Generic;

namespace _06._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> queue = new Queue<string>();

            while (true)
            {
                string customer = Console.ReadLine();

                if (customer == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine($"{queue.Dequeue()}");

                    }


                    queue.Clear();
                }
                else if (customer == "End")
                {
                    Console.WriteLine($"{queue.Count} people remaining.");
                    return;
                    
                }
                else
                {
                    queue.Enqueue(customer);

                }
            }
        }
    }
}
