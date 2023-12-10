using System;

class Program
{
    static void Main()
    {
        var activities = new Activity[]
        {
            new Running(new DateTime(2023, 12, 1), 30, 3.0),
            new Cycling(new DateTime(2023, 12, 2), 45, 20.0),
            new Swimming(new DateTime(2023, 12, 3), 60, 20),
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}