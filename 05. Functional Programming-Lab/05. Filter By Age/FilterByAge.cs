using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class FilterByAge
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<KeyValuePair<string, int>> people = new List<KeyValuePair<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] nameAge = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string name = nameAge[0];
                int age = int.Parse(nameAge[1]);


                people.Add(new KeyValuePair<string, int>(name, age));
                
            }

            string condition = Console.ReadLine();
            int ageCondition = int.Parse(Console.ReadLine());
            string[] format = Console.ReadLine().Split();


            people.Where(p => condition == "younger" ? p.Value <= ageCondition : p.Value >= ageCondition)
                .ToList()
                .ForEach(p => Print(p, format));


        }

        static void Print(KeyValuePair<string, int> person, string[] format)
        {
            if (format.Length == 2)
            {
                Console.WriteLine(format[0] == "name" ?
                    $"{person.Key} - {person.Value}":
                    $"{person.Value} - {person.Key}");
            }
            else
            {
                Console.WriteLine(format[0] == "name" ?
                    $"{person.Key}":
                    $"{person.Value}");
            }


        }

    }
}
