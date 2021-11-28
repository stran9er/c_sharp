using System;

namespace NumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            try  // Error handler.
            {
                var SumOfNumbers = 0; // Initialized variable to hold our sum.
                while (true)
                {
                    Console.WriteLine("Enter a number or OK to quit.");
                    var input = Console.ReadLine();

                    if (input == "OK" || input == "ok")
                    {
                        break;
                    }
                    else
                    {
                        SumOfNumbers = Convert.ToInt32(input) + SumOfNumbers; // Sum = input + Sum
                        Console.WriteLine("Sum:  {0}", SumOfNumbers);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Entry.");
            }
        }
    }
}
