using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int choice = DisplayMenu();

        Activity activity = CreateActivity(choice);

        activity.Run();

        Console.ReadLine();

    }

    static int DisplayMenu()
    {
        Console.WriteLine("Mindfulness Activities:");
        Console.WriteLine("1. Breathing Activity:");
        Console.WriteLine("2. Reflection Activity:");
        Console.WriteLine("3. Listing Activity:");

        Console.Write("Choose an activity (1-3): ");
        return int.Parse(Console.ReadLine());
    }

    static Activity CreateActivity(int choice)
    {
        switch (choice)
        {
            case 1:
                return new BreathingActivity();
            case 2:
                return new ReflectionActivity();
            case 3:
                return new ListingActivity();
            default:
                throw new ArgumentException("Invalid choice");
        }
    }
}