using System;
using System.Collections.Generic;
using System.Linq;

namespace String_List_Numbers
// Find Duplicates within a list that has been converted to Int32.
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a series of names separated by a hyphen.
            Console.WriteLine("\nEnter some numbers separated by a hyphen:");
            var anotherInput = Console.ReadLine();
            
            
            do
            {
                // If nothing was entered, exit.
                if (String.IsNullOrEmpty(anotherInput))
                {
                    Console.WriteLine("Nothing was entered.");
                    break;
                }
                
                // Set a list to hold the numbers entered by the user.
                var moreNumbers = new List<int>(anotherInput.Split('-').Select(i => int.Parse(i)).ToList());
                
                if (moreNumbers.Count() != moreNumbers.Distinct().Count())
                {
                    Console.WriteLine("Duplicate Exists.");
                    break;
                }
                else
                {
                    Console.WriteLine("Valid List.");
                    break;
                }

            } while (true);
        }
    }
}
