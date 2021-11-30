using System;

namespace Character_Counter
{
    class Program
    {
        static void Main(string[] args)
        {

            /* We may need to count how many times a character was found in a string.
             * 
             * In this example we will count how many vowels are in an user defined word.
             * We start by asking the user to enter a word.
             * Then we return how many vowels were found in the word.
             */
             
            Console.WriteLine("Enter a word to find how many vowels are in it.");
            
            // Variable to hold the user defined word.
            var theWord = Console.ReadLine().ToLower();
            // Variable to hold the vowel count.
            var vowelCount = 0;
            
            for (int i = 0; i < theWord.Length; i++)
            {
                // We can replace the characters for any as needed.
                if (theWord[i] == 'a' || theWord[i] == 'e' || theWord[i] == 'i' 
                    || theWord[i] == '0' ||  theWord[i] == 'u')
                {
                    vowelCount++; // Incremental
                }
            }
            if (vowelCount == 0)
            {
                Console.WriteLine("No vowels found.");
            }
            else
            {
                Console.WriteLine("There were {0} vowels in your word.", vowelCount);
            }
        }
    }
}
