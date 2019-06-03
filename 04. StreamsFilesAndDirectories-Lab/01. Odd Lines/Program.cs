using System;
using System.IO;
using System.Reflection;

namespace _01._Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = "resource";
            string file = "Input.txt";
            string output = "Output.txt";
            string filePath = Path.Combine(folder, file);

            using (var reader = new StreamReader(filePath))
            {
                using (var writer = new StreamWriter(Path.Combine(folder, output)))
                {


                    int count = 0;

                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        count++;

                        if (count % 2 == 0)
                        {
                            writer.WriteLine(line);
                            Console.WriteLine(line);
                        }

                        line = reader.ReadLine();
                    }
                }

            }
        }
    }
}
