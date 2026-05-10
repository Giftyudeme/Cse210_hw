using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            // Generate random magic number
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("I have chosen a magic number between 1 and 100.");

            // Loop until correct guess
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Stretch challenge
            Console.WriteLine($"Number of guesses: {guessCount}");

            // Ask to play again
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Thanks for playing!");
    }
}