using System;
using System.Collections.Generic;

/*
 * Asks the user to enter numbers until quit is entered.
 * Then display only the unique numbers.
 */
namespace Procedural_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or 'Quit' to exit.");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;
                numbers.Add(Convert.ToInt32(input));
            }

            Console.WriteLine("Unique Numbers:");
            foreach (var number in UniqueNumbers(numbers))
                Console.WriteLine(number);
        }
        
        public static  List<int>UniqueNumbers(List<int> num)
        {
            // Takes the defined list.
            var numbers = new List<int>(num);
            // Holds unique Numbers.
            var uNumbers = new List<int>();

            foreach (var item in numbers)
            {
                if (!uNumbers.Contains(item))
                    uNumbers.Add(item);
            }
            return uNumbers;

        }
    }
}
