using System;

namespace MoreArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers  = new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Length: Size of the array. 
            Console.WriteLine("The array's length is:  "+numbers.Length);

            // IndexOf():  Find the position of an element.
            var index = Array.IndexOf(numbers, 6);
            Console.WriteLine("\nThe index of the element with the value of 6 is:  " + index);

            // Clear():  Clears the established range within an array.
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("\nLet's Clear() the range 0, 2: ");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            int[] dupArray = new int[3];
            Array.Copy(numbers, dupArray, 3);

            Console.WriteLine("\nCopy the first 3 elements of an array into a new array:");
            foreach(var j in dupArray)
            {
                Console.WriteLine(j);
            }

            // Sort():  Sorts the array. 
            var rndNum = new[] { 23, 12, 10, 200, 5 };
            Console.WriteLine("\nLet's sort an array.");
            Array.Sort(rndNum);

            foreach (var item in rndNum)
            {
                Console.WriteLine(item);
            }

            // Reverse()
            Array.Reverse(rndNum);

            Console.WriteLine("\nLet's reverse the order of the array.");
            foreach(var i in rndNum)
            {
                Console.WriteLine(i);
            }
        }

    }
}
