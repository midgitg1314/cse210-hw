using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //!!THIS PART ASKS THE USER FOR THE NUMBER!!
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        // Console.Write("What is the magic number? ");
        // int number = int.Parse(Console.ReadLine());

        int numberOfGuesses = 0;

        //!! THIS PART OF THE CODE ASKS THE USER FOR A GUESS!!
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        // !!THIS PART OF THE CODE TELLS THE USER IF THE GUESS
        // WAS HIGHER OR LOWER THAN THE NUMBER!!
        while (guess != number)
        {
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                // Stretch
                numberOfGuesses = numberOfGuesses ++;
        }
        Console.WriteLine($"You guessed it! It took you {numberOfGuesses} guesses.");
        Console.WriteLine("Do you want to play again? (Yes or no)");
        string response = Console.ReadLine();
    }
}
// In the Guess My Number game the computer picks a magic 
// number, and then the user tries to guess it. 
// After each guess, the computer tells the user to 
// guess "higher" or "lower" until they guess the magic 
// number.