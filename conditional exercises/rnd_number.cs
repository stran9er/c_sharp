using System;

namespace rnd_num_game
{
    class Program
    {
        static void Main(string[] args)
        {
            var rndNum = new Random().Next(1, 10);  // Set's a random number from 1 to 10.
            var AllottedAttempts = 5;
            var AttemptsTaken = 0;
            Console.WriteLine("Guess a number between 1 and 10.");

            // A simple loop to keep control. 
            while (AttemptsTaken < AllottedAttempts)
            {
                var userGuess = Convert.ToInt32(Console.ReadLine());
                AttemptsTaken++;
                // Conditional statements within the loop.
                if (userGuess == rndNum)
                {
                    Console.WriteLine($"You won! {rndNum} was right!");
                    break;
                }
                if (userGuess < rndNum)
                {
                    Console.WriteLine("Your guess, {0}, was too low.", userGuess);
                }
                if (userGuess > rndNum)
                {
                    Console.WriteLine("Your guess, {0}, was too high.", userGuess);
                }
                if (AttemptsTaken == AllottedAttempts)
                {
                    Console.WriteLine($"Too bad! You are out of attempts! The number was {rndNum}.");
                }
                Console.WriteLine($"You have {AllottedAttempts - AttemptsTaken} attempts  left.");
            }
        }
    }
}
