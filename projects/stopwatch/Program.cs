using System;

namespace Classes_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A simple Stopwatch... \nType 'start' to start it, 'stop' to stop it.\nIf you would like to quit, type 'quit'.");
            string input = Console.ReadLine().ToLower();

            // Initiate our class.
            var stopwatch = new Stopwatch();
            do
            {
                if (input == "start")
                {
                    stopwatch.Start();
                    Console.WriteLine("Running... Stop to stop.");
                }
                else if (input == "stop")
                {
                    stopwatch.Stop();
                    Console.WriteLine("Stopped.");
                    Console.WriteLine(stopwatch.Stop());

                    Console.WriteLine("\nStart or quit the stopwatch?");
                }
                else if (input == "quit")
                {
                    break;
                }
                input = Console.ReadLine();

            } while (true);
        }
    }
}
