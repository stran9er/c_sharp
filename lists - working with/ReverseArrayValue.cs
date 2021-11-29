using System;
using System.Collections.Generic;

namespace ReverseArrayValue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array to a name.
            var userName = new string[1];

            // Ask the user to enter a name.
            Console.WriteLine("\nPlease enter your name: ");
            var userInput = Console.ReadLine();

            // Assign the user's input to the array index.
            userName[0] = userInput;
            
            // Display their original entry.  We could get it directly from the input, but lets work with arrays.
            Console.WriteLine("You entered {0}.", userName[0]);

            // Create a character array and push the original array to the char array.
            char[] reversedName = userName[0].ToCharArray();
            // var to hold the reversed string.
            var reverse = String.Empty;

            for (int i = reversedName.Length -1; i>=0; i--)
            {
                reverse += reversedName[i];
            }
            Console.WriteLine("Your name reads {0}, backwards.",reverse);
        }
    }
}
