using System;

namespace Strings_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            // We can set up string or use var.  C# detects the data type. 
            string FirstName = "John";
            var MiddleName = "Sam";
            var LastName = "Handcock";

            // We can concantate the string.
            var FullNameOne = FirstName + " " + MiddleName + " " + LastName;
            Console.WriteLine(FullNameOne);

            // Or we can use string.Format. 
            var FullNameTwo = string.Format("{0} {1} {2}", FirstName, MiddleName, LastName);
            Console.WriteLine(FullNameTwo);

            // You can work with strings in array's. 
            var RandomNames = new string[4] { "Aurora", "Eli", "Nova", "Troy" };
            foreach (var item in RandomNames)
            {
                Console.WriteLine(item);
            }
            // We can also join the array for display.
            var formattedArray = string.Join(", ", RandomNames);
            Console.WriteLine(formattedArray);

            // If left unchecked, strings can become too long, difficult to format and work with.
            var HardRead = "\nA string could be too long, or just too much to enter in a single line. For example:\nWe want to have the user go to. C:\\Program Files (x86)\\AMD\\Chipset_IODrivers\\ \nC:\\Program Files\\Sublime Text";
            Console.WriteLine(HardRead);

            var EasyRead = @"nA string could be too long, or just too much to enter in a single line. For example:
We want to have the user go to. C:\Program Files (x86)\AMD\Chipset_IODrivers
C:\Program Files\Sublime Text";

            Console.WriteLine("\n"+ EasyRead);
        }
    }
}
