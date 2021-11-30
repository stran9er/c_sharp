using System;

namespace ReversedString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name.");
            var input = Console.ReadLine();
            var reversed = ReversedName(input);

            Console.WriteLine("Your name reads {0}, backwards.", reversed);

        }
        
        
        // Procedure.
        public static string ReversedName(string name)
        {
            var userName = new string[1] {  name };
            char[] reversedName = userName[0].ToCharArray();
            var reverse = String.Empty;

            for (int i = reversedName.Length - 1; i >= 0; i--)
            {
                reverse += reversedName[i];

            }
            return reverse;
        }
    }
}
