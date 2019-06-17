using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class AverageStudentGrade
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            var records = new Dictionary<string, List<double>>();

            for (int i = 0; i < countStudents; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!records.ContainsKey(name))
                {
                    records[name] = new List<double>() {grade};
                }
                else
                {
                    records[name].Add(grade);
                }
            }

            foreach (var record in records)
            {
                Console.WriteLine($"{record.Key} -> {string.Join(' ', record.Value)} (avg: {record.Value.Average():f2})");
            }
        }
    }
}
