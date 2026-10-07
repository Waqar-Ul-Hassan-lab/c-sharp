using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Game settings and tracking variables
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int guesses;
            int randomNumber;
            string response;

            Random random = new Random();

            // Outer loop: manages repeated game sessions
            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                randomNumber = random.Next(min, max + 1);

                // Inner loop: prompts user until the correct number is guessed
                while (guess != randomNumber)
                {
                    Console.Write("Enter a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess < randomNumber)
                    {
                        Console.WriteLine(guess + " is low");
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine(guess + " is high");
                    }

                    guesses++;
                    Console.WriteLine();
                }

                // Victory output
                Console.WriteLine("You Win! The number was " + randomNumber);
                Console.WriteLine("You guessed the number in " + guesses + " attempts");
                Console.WriteLine($"Random number was {randomNumber} and total guesses were {guesses}");
                Console.WriteLine();

                // Prompt user to play again
                Console.Write("Do you want to play again (Y/N) : ");
                response = (Console.ReadLine() ?? "").ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Thanks for playing!");
        }
    }
}