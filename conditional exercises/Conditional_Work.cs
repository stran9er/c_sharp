using System;

namespace ConditionalWork
{
    public enum Stores // Used in the switch case in line 38.
    {
        Gap, 
        OldNavy,
        Union, 
        HM
    }


    partial class Program
    {
        static void Main(string[] args)
        {
            var number = 20;
            var myVar = 10;
            if (number > myVar)
            {
                Console.WriteLine(string.Format("True, number {0} is greater than my variable {1}", number, myVar));
            }
            else
            {
                Console.WriteLine(string.Format("False, number {0} is not greater than my variable {1}", number, myVar));
            }

            // Let's use a boolean variable to determine the conditional format using an operator.
            bool cSharpIsFun = true;

            string answer = (cSharpIsFun) ? "Sure is!" : "What?";
            Console.WriteLine(answer);


            // If statements can become hard to manage if they grow large.  That is why it's recommended to use the swtich case for longer conditionals. 
            var store = Stores.Union;
            switch (store)
            {
                case Stores.Gap:
                case Stores.OldNavy:
                    Console.WriteLine("Gap and Old Navy are both owned by the same corporation.");
                    break;
                case Stores.HM:
                    Console.WriteLine("H&M can have decent items for a decent price.");
                    break;
                case Stores.Union:
                    Console.WriteLine("The only Union store I have seen was in California.");
                    break;
                default:
                    Console.WriteLine("That's it for stores listed.");
                    break;

            }
        }
    }
}
