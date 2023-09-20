using System;

class Program
{
        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }
        static int SquareNumber (int userNumber)
        {
            int squaredNumber = userNumber * userNumber;
            return squaredNumber;
        }
        static void DisplayResult ()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int squaredNumber = SquareNumber(userNumber);

            Console.WriteLine($"Hello, {userName}!");
            Console.WriteLine($"The square of your favorite number {userNumber} is {squaredNumber}.");
        }
        static void Main(string[] args)
        {
            DisplayResult();
        }
    }
