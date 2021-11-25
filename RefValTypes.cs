using System;

namespace Ref_Val_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let's set some variables.
            var a = 10;
            var b = a;
            b++;
            var c = 22;

            Console.WriteLine(string.Format("The stored values are:\n\ta: {0}, b: {1}, c: {2}", a, b,c));

            // Let's create two array's and manipulate their values.
            var array_One = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("The value of index 0 in array one is: " + array_One[0]);
            
            int[] array_Two = array_One; // Copy array One into array Two
            Console.WriteLine("The value of index 0 in array two is: " + array_Two[0]);
            
            array_Two[0] = 0; // Modifying index 0 in array two will also modify index 0 in array one by reference. 
            Console.WriteLine("The new value of index 0 in array one is: " + array_One[0]);

            array_One[3] = 7;
            array_One[4] = 8;
            // Let's loop through array two and notice how we modified index 3 and 4 by reference.
            for (int i = 0; i < array_Two.Length; i++)
            {
                Console.WriteLine(array_Two[i]);
            }
        }
    }
}

