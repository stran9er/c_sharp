using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Ask for more than 5 numbers to be entered, separated by a comma.
 * If the list does not have more than 5 numbers, display "Invalid List"
 * Otherwise, display the smallest 3 numbers in the list.
*/

namespace Arrays_and_List_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter more than 5 numbers separated by a (,):");
            var userNumbers = Console.ReadLine();
            
            // Create the list with the user input.
            var ListMe = new List<int>(userNumbers.Split(',').Select(i => int.Parse(i)).ToList());

            if (ListMe.Count > 5)
            {
                ListMe.Sort();
                Console.WriteLine("\nThe three smallest numbers in the list are:");
                // We can determine the smallest desired numbers by changing the 3 in the operation below.
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(ListMe[i]);
                }
            }
            else
            {
                Console.WriteLine("Invalid list.");
            } 
        }
    }
}
