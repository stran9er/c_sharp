using System;


namespace More_On_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2D Rectangular Array
            var ArrayOne = new int[3, 5];   // 3 rows, 5 columns. Not initialized.

            var ArrayTwo = new int[3, 5]    // Initialized multidimensional array, 3 rows, 5 columns
            {                           
               // Rectangular Array [Row, Equal Size Column]
                { 1,  2,  3,  4,  5},   // {0, 1, 2, 3, 4}  [0]
                { 6,  7,  8,  9, 10},   // {0, 1, 2, 3, 4}  [1]
                {11, 12, 13, 14, 15}    // {0, 1, 2, 3, 4}  [2]
            };
            
            // We can access it by row and colum ID. 
            var ArrayElement = ArrayTwo[1, 3];  // This refers to the number 9. 

            // Jagged Arrays.
            var jag_array = new int[3][];
            jag_array[0] = new int[4];  // {0, 1, 2, 3}
            jag_array[1] = new int[5];  // {0, 1, 2, 3, 4}
            jag_array[2] = new int[3];  // {0, 1, 2}

            // We can access it by array and index. 
            jag_array[0][0] = 1;

            // We can work with the entire 2D array.
            foreach (var item in ArrayTwo)
            {
                Console.WriteLine(item);
            }

            // Or individual. 
            Console.WriteLine("The item held in ArrayTwo[1, 3] is:  " +ArrayElement);


           }
    }
}
