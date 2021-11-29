using System;
using System.Collections.Generic;
using System.Linq;

namespace Text_Time_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Ask the user to enter some numbers separated by a hyphen.
             * Work out if the numbers are consecutive and display "Consecutive".
             * Oterwise display "Not Consecutive"
             */
            Console.WriteLine("Enter some numbers separated by a hyphen (-).");
            var input = Console.ReadLine();
            var numberList = new List<int>(input.Split('-').Select(i => int.Parse(i)).ToList());

            // Let's determine if the list is consecutive.
            var isConsecutive = numberList.Select((n, index) => n == index + numberList.ElementAt(0)).All(n => n);
            
            if (isConsecutive == true)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }
    }
}
