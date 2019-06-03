using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "resource";
            string input = "Input.txt";
            string output = "Output.txt";

            string inputPath = Path.Combine(path, input);
            string outputPath = Path.Combine(path, output);


            using (var reader = new StreamReader(inputPath))
            {
                using (var writer = new StreamWriter(outputPath))
                {
                    int count = 0;

                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        count++;
                        writer.WriteLine($"{count}. {line}");

                        line = reader.ReadLine();
                    }
                }

            }
        }
    }
}
