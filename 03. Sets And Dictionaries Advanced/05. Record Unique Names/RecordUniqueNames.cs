﻿using System;
using System.Collections.Generic;

namespace _05._Record_Unique_Names
{
    class RecordUniqueNames
    {
        static void Main(string[] args)
        {
            var countNames = int.Parse(Console.ReadLine());

            var set = new HashSet<string>();

            for (int i = 0; i < countNames; i++)
            {
                var name = Console.ReadLine();

                set.Add(name);
            }

            foreach (var name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
