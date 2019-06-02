using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class CapitalLetter
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(w => char.IsUpper(w[0]))
                .ToArray();

            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
