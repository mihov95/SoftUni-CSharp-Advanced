using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var stack = new Stack<int>(input);
            var fullCommand = Console.ReadLine().ToLower();
               


            while (!fullCommand.Equals("end"))
            {

                var tokens = fullCommand.Split();
                var command = tokens[0].ToLower();

                if (command.Equals("add"))
                {
                    var firstNumToAdd = int.Parse(tokens[1]);
                    var secondNumToAdd = int.Parse(tokens[2]);

                    stack.Push(firstNumToAdd);
                    stack.Push(secondNumToAdd);
                } 
                else if (command.Equals("remove"))
                {
                    var countNumsToRemove = int.Parse(tokens[1]);
                    if (countNumsToRemove > stack.Count)
                    {
                        continue;
                    }

                    for (int i = 0; i < countNumsToRemove; i++)
                    {
                        stack.Pop();
                    }
                }

                fullCommand = Console.ReadLine().ToLower();
            }

            var sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
