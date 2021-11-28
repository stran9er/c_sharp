using System;
/*
We will explore some ways to see the maximum of two values.  Using if statements and the Math class.
We will ask the user to input two numbers, then process the numbers to determine which is max.
*/

namespace MaxMin_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Enter a value for number one:  "); // Ask's the user to input the value for number 1.
            var numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for number two:  "); // Ask's the user to input the value for number 2.
            var numberTwo = Convert.ToInt32(Console.ReadLine());

            if (numberOne > numberTwo) // Determines is number 1 is greater than number 2.
            {
                Console.WriteLine(string.Format("{0} is the Maximum out of {1} and {2}", numberOne, numberOne, numberTwo));
            }
            else // If the condition above is false, it means number 2 is greater than number 1.
            {
                Console.WriteLine(string.Format("{0} is the Maximum out of {1} and {2}", numberTwo, numberOne, numberTwo));
            }

            Console.WriteLine("\nFinding the max using the Math.Max method.");
            string str = "The greater of {0} and {1} is {2}."; // Set's the string message to be used in our CW, easier to read/edit.

            Console.WriteLine(str, numberOne, numberTwo, Math.Max(numberOne, numberTwo)); // Math.Max finds the Max of the values parsed.
        }
    }
}
