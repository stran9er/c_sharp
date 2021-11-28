using System;
/*
This example asks the user to enter a number, between 1 and 10. 
If the user enters a number within the range desired, the console will return valid.
Otherwise it will return Invalid and ask the user to try again. 
*/

namespace IntValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // Set's a flag for the loop.
            do
            {
                Console.WriteLine("Please enter a number between 1 and 10.");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number >= 1 && number <= 10)
                {
                    Console.WriteLine("Valid!");
                    break;  // Terminate's the validation if the user entry is correct.
                }
                else
                { 
                    int triesRemaining = (4-i); // 0 index, used to tell the user how many attempts he has left.
                    i++; // Increment, used to control the loop.
                    Console.WriteLine(string.Format("Invalid.\nPlease try again, you have {0} tries remaining.", triesRemaining));
                }
            } while (i < 5);
        }
    }
}
