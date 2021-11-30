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
            Console.WriteLine("{0} has {1} vowels.", theWord, VowelCount(theWord));
        
        }
        public static int VowelCount(string word)
        {
            var vowels = new List<char>(new char[] {'a', 'e'. 'i', 'o', 'u'});
            var vowelsCount = 0;
            
            foreach(var item in word.ToLower())
            {
                if (vowels.Contains(item))
                    vowelsCount++;
            }
            return vowelsCount;
        }
    }
}
