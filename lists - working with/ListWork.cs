using System;
using System.Collections.Generic;

namespace ListsWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // List initialized (int) with values: 1, 2, 3, 4, 5
            var numbers = new List<int>() {1, 2, 3, 4, 5, 7};
            // Add() 6 to the list.
            numbers.Add(6);
            // Add the a range [3] to the list, 7, 8, 9
            numbers.AddRange(new int[3] {7, 8, 9});
            
            // Let's see the contents of our list. 
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            // IndexOf() finds the index of the given value. If the value repeats in the list, 0 will be returned.
            Console.WriteLine("\nIndex of 6: " + numbers.IndexOf(6));
           
            // LastIndexOf() returns the last index of a value.  
            Console.WriteLine("\nLast Idex of 5: " + numbers.LastIndexOf(5));
            
            // Count tells us how long the list is.
            Console.WriteLine("\nThe list count:  " + numbers.Count);
            
            //Remove(), removes an item from the list.
            Console.WriteLine("\nRemove 5.");
            numbers.Remove(5);
            foreach (var j in numbers)
            {
                Console.WriteLine(j);
            }

            // If there are multiple indexes with the same value to be removed.
            Console.WriteLine("\nRemove the 7's from the list.");
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 7)
                {
                    numbers.Remove(numbers[i]);
                    Console.WriteLine($"Removed index: {i}");
                }
            }

            // Display the new list, after modified to have the 7's removed.
            Console.WriteLine("\nNo 7's found.");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            // Clear() deletes the values of the list.
            numbers.Clear();
            Console.WriteLine("Count afer Clear():" + numbers.Count);

            // Same can be done with other data types.
            Console.WriteLine("\nWe can do the same as above with other data types.");
            var names = new List<string>() {"Eli", "Nova", "Aurora" };
            names.Add("Katara");
            foreach (var item in names)
            {
                Console.WriteLine(item);

            }
            

        }
    }
}
