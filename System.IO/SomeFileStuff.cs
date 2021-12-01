using System;
using System.Collections.Generic;
using System.IO;

namespace SysIO_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file and displays the number of words.

            var content = File.ReadAllText(@"e:\readme.txt"); 
            var wordCount = content.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("There are {0} words in the file.", wordCount.Length);

            // Display the longest word within the file and it's position.

            // List to hold the words for comparison.
            var words = new List<string>(content.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries));
            if (words.Count>0)
            {
                int FileIndex = 1;
                string LongestWord = words[0];

                for (int i = 0; i < words.Count; i++)
                {
                    string item = words[i];

                    if (item.Length > LongestWord.Length)
                    {
                        LongestWord = item;
                        FileIndex = i + 1;
                    }
                }
                Console.WriteLine("Longest Word: {0}\nFound at Position: {1}", LongestWord, FileIndex);
            }
            Console.WriteLine("The file is empty.");
        }
    }
}
