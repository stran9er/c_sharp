using System;
using System.Collections.Generic;
using System.Linq;

/*
 * We will ask the user to enter 5 numbers.
 * If the number already exists in the array we will ask for another one.
 * Once 5 unique numbers are entered, sort and display them.
*/ 
namespace Arrays_and_List_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array to hold the numbers.
            var uniqueNumbers = new int[5];

            // A loop to ask for numbers.
            for (int i = 0; i < uniqueNumbers.Length; i++)
            {
                Console.WriteLine("Enter a number for index {0}.", i);
                // Validation loop.
                do
                {
                    var userNumber = Convert.ToInt32(Console.ReadLine());
                    // Let's see if the user input exists in the array.
                    var numberExists = uniqueNumbers.Contains(userNumber);

                    // If the number does not exist, then we add it.
                    if (!numberExists)
                    {
                        uniqueNumbers[i] = userNumber;
                        break;
                    }
                    // If the number exists, we ask for another one.
                    Console.WriteLine("That number already exists - try again.");
                  
                } while (true);
            }

            // Sort the array and display it. 
            Console.WriteLine("The numbers entered, in order are: ");
            Array.Sort(uniqueNumbers);
            foreach (var item in uniqueNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
