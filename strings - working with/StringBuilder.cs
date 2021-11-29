using System;
using System.Text;

// Manipulate string with StringBuilder

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Builder
            var b = new StringBuilder();

            b
              .Append('=', 10)
              .AppendLine()
              .Append("Some Text")
              .AppendLine()
              .Append('=', 10);

            Console.WriteLine(b);

            // We can replace, remove and insert items into String Builder.

            b
             .Replace('=', '*')
             .Remove(0, 10) // Starts at index 0 and goes to index 10.
             .Insert(0, new string('^', 10));

            Console.WriteLine("\n" + b);


        }
     }
}
