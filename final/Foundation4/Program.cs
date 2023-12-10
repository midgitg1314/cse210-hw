using System;

class Program
{
    static void Main()
    {
        var activities = new Activity[3];

        for (int i=0; i<3; i++)
        {
            Console.WriteLine($"Enter details for Activity {i+1}:");

            Console.Write($"Enter date(yyyy-MM-dd): ");
            DateTime date;
            while(!DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out date ))
            {
                Console.Write("Invalid date format. Please enter a valid date (yyyy-MM-dd): ");
            }
            // new Running(new DateTime(2023, 12, 1), 30, 3.0),
            // new Cycling(new DateTime(2023, 12, 2), 45, 20.0),
            // new Swimming(new DateTime(2023, 12, 3), 60, 20),
            Console.Write("Enter time in minutes: ");
            int minutes;
            while (!int.TryParse(Console.ReadLine(), out minutes) || minutes <= 0)
            {
                Console.Write("Invalid input. Please enter a valid positive integer for time: ");
            }

            Console.Write("Enter distance: ");
            double distance;
            while (!double.TryParse(Console.ReadLine(), out distance) || distance <= 0)
            {
                Console.Write("Invalid input. Please enter a valid positive number for distance: ");
            }

            Console.Write("Enter activity type (Running/Cycling/Swimming): ");
            string activityType =  Console.ReadLine();

            switch (activityType.ToLower())
            {
                case "running":
                    activities[i] = new Running(date, minutes, distance);
                    break;
                case "cycling":
                    activities[i] = new Cycling(date,minutes,distance);
                    break;
                case "swimming":
                    activities[i]= new Swimming(date, minutes, (int)distance);
                    break;
                default:
                    Console.WriteLine("Invalid activity type. Skipping this entry.");
                    i--;
                    break;
                
            }
        }
        foreach (var activity in activities)
        {
            if(activity != null)
                Console.WriteLine(activity.GetSummary());
        }
    }
}