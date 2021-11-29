using System;
using System.Collections.Generic;
using System.Linq;
/*
 * Ask the user to continuosly enter a number or type 'Quit' to exit.
 * The list may contain duplicates.
 * Display only the unique numbers found in the list.
*/
namespace UniqueLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var moreNumbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or 'Quit' to exit.");
                var input = Console.ReadLine(); 

                if (input == "QUIT" || input == "quit")
                {
                    break;
                }
                else
                {
                    moreNumbers.Add(Convert.ToInt32(input));
                }
            }
            // Let's create a new list to hold distinct values.
            var uniqueList = moreNumbers.Distinct();
            
            Console.WriteLine("\nThe unique items in the list are:");
            foreach (var item in uniqueList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
