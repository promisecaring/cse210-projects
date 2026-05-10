using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        string playAgain = "yes";

        // Keep playing as long as the user enters "yes"
        while (playAgain.ToLower() == "yes")
        {
            // Generate a random magic number between 1 and 100
            int magicNumber = random.Next(1, 101);

            int guess = 0;
            int guessCount = 0;

            Console.WriteLine("I have selected a magic number between 1 and 100.");

            // Continue until the user guesses correctly
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

            // Display the number of guesses
            Console.WriteLine($"It took you {guessCount} guesses.");

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();

            Console.WriteLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}