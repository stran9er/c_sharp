using System;

namespace Factorial_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the factorial of a number n! = n(n-1)x...x1
            var factorial = 1;
            Console.WriteLine("Enter a number to find it's factorial: ");
            var input = Convert.ToInt32(Console.ReadLine());

            while (input !=1)
            {
                factorial = factorial * input;
                input = input - 1;
            }
            Console.WriteLine("The factorial is: " + factorial);

        }
    }
}
