using System;
using System.Linq;

namespace Split_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
          /*
           * This code will return a PascalCase variable based on the user's entries.
           * We ask the user to enter a few words separated by a space.
          */
        
            Console.WriteLine("Enter a few words seperated by space.");
            var userWords = Console.ReadLine();

            // If nothing is entered, we will simply let the user know.
            if (userWords.Length ==0)
            {
                Console.WriteLine("Nothing was entered.");
            }
            else
            {
                // Let's create a new variable to hold all the words entered after we remove the desiganted characters.
                var cleanWords = userWords.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries) 
                    .Select(word => word.Substring(0, 1).ToUpper() +
                    word.Substring(1).ToLower());
                /*
                 * We can add more characters to be Split. For example, if you want to filter ('<', '%', '#', '-') as well.
                 * Add those characters to the existing Split.  ...Split(new[] {' ', '<', '%', '-'}, ...
                 */

                Console.WriteLine(String.Concat(cleanWords));
            }
        }
    }
}
