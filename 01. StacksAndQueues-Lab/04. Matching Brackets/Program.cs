using System;
using System.Collections.Generic;

namespace _04._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var exp = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < exp.Length; i++)
            {
                char ch = exp[i];

                if (ch == '(')
                {
                    stack.Push(i);
                }
                else if (ch ==')')
                {
                    int startIndex = stack.Pop();
                    string contest = exp.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(contest);
                }
            }
        }
    }
}
