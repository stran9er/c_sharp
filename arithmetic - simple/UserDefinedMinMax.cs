using System;
using System.Collections.Generic;
using System.Linq;

namespace UserDefinedMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers separated by a comma.");
            var NumberSeries = Console.ReadLine();
            // We need to remove the , before using the numbers as int.
            string[] num_array = NumberSeries.Split(',');
            // We make a list to hold our numbers.
            List<int> numList = new List<int>();

            for (var i = 0; i < num_array.Length; i++)
            {
                // Parse the numbers into the list.
                if (int.TryParse(num_array[i], out int list_holder))
                {
                    numList.Add(list_holder);
                }
            }
            // Prints the Maximum number into console.
            Console.WriteLine("Max: {0}", numList.Max());
            // Prints the Minimum number into console.
            Console.WriteLine("Min: {0}", numList.Min());

        }
    }
}
