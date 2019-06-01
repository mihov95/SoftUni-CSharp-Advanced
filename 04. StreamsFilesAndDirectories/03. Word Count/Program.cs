using System;
using System.IO;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "files";
            string wordsToRead = "words.txt";
            string input = "text.txt";
            string output = "output.txt";


            using (var readerWords = new StreamReader(Path.Combine(path, wordsToRead)))
            {
                using (var readerText = new StreamReader(Path.Combine(path, input)))
                {

                    string[] words = readerWords.ReadLine().Split();
                    string[] wordsInText = readerText.ReadLine().Split();

                    int counter = 0;

                    foreach (var word in words)
                    {
                        word.ToLower();

                        foreach (var wordToMatch in wordsInText)
                        {
                            wordToMatch.ToLower();

                            for (int i = 0; i < wordsInText.Length; i++)
                            {
                                if (wordToMatch == word)
                                {
                                    counter++;
                                }
                            }

                            Console.WriteLine($"{wordToMatch} - {counter}");
                        }
                    }


                }
            }

        }
    }
}
