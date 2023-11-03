using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Create a menu system to allow the user to choose an activity
        int choice = DisplayMenu();
        int duration = GetDuration();

        //Create an instance of the selected activity
        Activity activity = null;

        switch (choice)
        {
            case 1:
                activity = new BreathingActivity(duration);
                break;
        
            case 2:
                activity = new ReflectionActivity(duration);
                break;
            case 3:
                activity = new ListingActivity(duration);
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
        if (activity != null){
            activity.Start();
            //Run the activity
            //End the activity
        }
    }
        static int DisplayMenu()
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            return int.Parse(Console.ReadLine());
        }
        static int GetDuration()
        {
            Console.Write("Enter the duration (in seconds): ");
            return int.Parse(Console.ReadLine());
        }
    
}