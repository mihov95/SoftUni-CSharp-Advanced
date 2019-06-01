using System;
using System.Collections.Generic;
using System.IO;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> dict = new Dictionary<string, int>();

            string path = "files";
            string wordsToRead = "words.txt";
            string input = "text.txt";
            string output = "output.txt";


            using (var readerWords = new StreamReader(Path.Combine(path, wordsToRead)))
            {
                using (var readerText = new StreamReader(Path.Combine(path, input)))
                {

                    string[] words = readerWords.ReadLine().Split();
                    string currentSentence = readerText.ReadLine();


                    while (currentSentence != null)
                    {
                        string[] wordsInSentece = currentSentence.Split();

                        foreach (var word in wordsInSentece)
                        {
                            foreach (var wordCheck in words)
                            {
                                if (wordCheck == word && dict.ContainsKey(word))
                                {
                                    dict[word]++;
                                }
                                else
                                {
                                    dict[word] = 1;
                                }
                            }
                        }

                        foreach (var word in dict)
                        {
                            Console.WriteLine($"{word.Key} - {word.Value}");
                        }
                        
                        currentSentence = readerText.ReadLine();
                    }






                }
            }

        }
    }
}
