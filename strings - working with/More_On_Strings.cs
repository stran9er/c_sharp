using System;

namespace More_On_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Formatting
             *      ToLower()   hello world
             *      ToUpper()   HELLO WORLD
             *      Trim()      Removes whitespace
             */
            var fullName = "Tony Starks ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("Upper: '{0}'", fullName.Trim().ToUpper());
            Console.WriteLine("Lower: '{0}'", fullName.Trim().ToLower());

            /*
             * Searching
             *      IndexOf('a')
             *      LastIndexOf("Hello")
             */
            var index = fullName.IndexOf(' ');
            /*
             * Substrings
             *      Substring(startIndex)
             *      Substring(startIndex, length)
             */
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("\nSubstrings");
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            /*
             * Replacing
             *      Replace ('a', 'b')                  Replaces a for b
             *      Replace("text", "replacement")      Replaces text for replacement
             */
            Console.WriteLine("\nReplacing Strings");
            Console.WriteLine(fullName.Replace("Tony", "Mr."));
            Console.WriteLine(fullName.Replace('a', 'A'));

            /*
             * Null Checking
             *      String.IsNullOrEmpty(str)
             *      String.IsNullOrWhiteSpace(str)
             */
            Console.WriteLine("\nNull Checking");
            if (String.IsNullOrEmpty(null))
            {
                Console.WriteLine("Invalid - Null String");
            }
            Console.WriteLine("\nEmpty String");
            if(String.IsNullOrEmpty(""))
            {
                Console.WriteLine("Invalid - Empty String");
            }
            Console.WriteLine("\nUser space entered.");
            if (String.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("Invalid - White Space Entered");
            }
            Console.WriteLine("\nUser space entered (Clean Version)");
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid - White Space Entered.");
            }

            /*
             * Splitting
             *      str.Split(' ')
             */
            Console.WriteLine("\nSplit Strings");
            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names [0]);
            Console.WriteLine("Last Name: " + names [1]);

            /*
             * Convert Str to Numbers
             *      string s = "1234";
             *      int i = int.Parse(s);           Throws Exception if emtpy or null string
             *      int j = Convert.ToInt32(s);     Returns 0 if emtpy or null string
             */

            Console.WriteLine("\nConverting Strings to Numbers:");

            var str = "25";
            Convert.ToInt32(str);
            Console.WriteLine(str);
            var age = Convert.ToByte(str);
            Console.WriteLine("The age is: " + age);

            /*
             * Converting Numbers to Str
             *      int i = 1234;
             *      string s = i.ToString();        "1234"
             *      string t = i.ToString("C");     "$1,234.00"
             *      string t = i.ToString("C0");    "$1,234"
             */
            Console.WriteLine("\nConverting Numbers to Strings");
            float price = 29.99f;
            Console.WriteLine(price.ToString("c"));
            Console.WriteLine(price.ToString("C0"));
        }
    }
}
