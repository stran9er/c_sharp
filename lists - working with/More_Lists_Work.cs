using System;
using System.Collections.Generic;

namespace More_Lists_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list.
            var names = new List<string>();

            while (true)
            {   // Ask the user to enter names. Offer instruction in how to break the loop.
                Console.WriteLine("Please enter a name, or leave blank to exit. ");
                var input = Console.ReadLine();
               
                // Control the loop.
                if (String.IsNullOrEmpty(input))
                {
                    break;
                }
                else
                {
                    // Add names to the list. 
                    names.Add(input);
                }
            }
            // Hold the count of names entered.
            var totalNames = names.Count;

            // Determine the message based on how many names entered.
            if (totalNames == 1)
            {
                Console.WriteLine(names[0] + " likes your post.");
            }
            if (totalNames == 2)
            {
                Console.WriteLine("{0} and {1} likes your post.", names[0], names[1]);
            }
            if (totalNames > 2)
            {
                Console.WriteLine("{0}, {1}, and {2} others like your post", names[0], names[1], (totalNames -2));
            }
        }
    }
}
