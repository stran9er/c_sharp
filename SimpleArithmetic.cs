using System;

namespace SimpleArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lets assign some variables.
            var a = 10;
            var b = 30;
            var c = 16;

            // Let's do simple arithmetic with the variables.
            Console.WriteLine("Addition:  "+ (a + b + c));
            Console.WriteLine("Subtraction:  "+ (a-b-c));
            Console.WriteLine("Division:  " +(float)(a/b/c));
            Console.WriteLine("Multiplication:  "+(a*b*c));

            // Let's do some comparisons.
            Console.WriteLine("Is a equal to b?  "+ (a==b));
            Console.WriteLine("Is b NOT equal to c?  "+ (a!=c));
            Console.WriteLine("Is a greater than c?  "+(a>c));

            // Let's work with logical operators
            Console.WriteLine("Is a greater than b and is c greater than b?  "+ (a>b && c>b));
            Console.WriteLine("Is a lesser than b and greater than b?  "  +(a<b && a>b));

            // Keep in mind the limitation of byte type (value from 0 to 255) 
            byte number = 255;
            number += 2;
            Console.WriteLine(number); // This will print one and you would have lost data. 
        }
    }
}

/*
Operators

Comparison Operators
  Equal to                        ==      a == b
  Not equal to                    !=      a != b
  Greater than                    >       a > b
  Greater than or equal to        >=      a >= b
  Lesser than                     <       a < b
  Lesser than or equal to         <=      a <= b

Assignment Operators
  Assignment          =       a = 1
  Addition            +=      a += 3      a = a + 3
  Subtraction         -=      a -= 3      a = a - 3
  Multiplication      *=      a *= 3
  Division            /=      a /= 3

Logical Operators
  And     &&      a && b
  Or      ||      a || b
  Not     !       !a

Bitwise Operators
  And     &       a & b  
  Or      |       a | b
 */
