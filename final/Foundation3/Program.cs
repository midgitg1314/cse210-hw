using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressLecture = new Address("123 Main St", "Rexburg", "ID", "USA");
        Lecture lectureEvent = new Lecture("Python", "Intro to Python", DateTime.Parse("2023-12-15"), "18:00", addressLecture, "Jennifer Victoria", 100);
        
        Address addressReception = new Address("321 2nd St", "Rexburg", "ID", "USA");
        Reception receptionEvent = new Reception("C#", "Intro to C#", DateTime.Parse("2023-12-15"), "17:00", addressReception, "rsvp@example.com");
        
        Address addressGathering = new Address("333 4th St", "Rexburg", "ID", "USA");
        OutdoorGathering gatheringEvent = new OutdoorGathering("Javascript", "Intro to Javascript", DateTime.Parse("2023-12-15"), "16:00", addressGathering);

        Console.WriteLine("Lecture Event Marketing Messages:");
        Console.WriteLine(lectureEvent.StandardDetails());
        Console.WriteLine(lectureEvent.FullDetails());
        Console.WriteLine(lectureEvent.ShortDescription());
        Console.WriteLine("\n"+ new string('-', 40) + "\n");
        
        Console.WriteLine("Reception Event Marketing Messages:");
        Console.WriteLine(receptionEvent.StandardDetails());
        Console.WriteLine(receptionEvent.FullDetails());
        Console.WriteLine(receptionEvent.ShortDescription());
        Console.WriteLine("\n"+ new string('-', 40) + "\n");
        
        Console.WriteLine("Outdoor Gathering Event Marketing Messages:");
        Console.WriteLine(gatheringEvent.StandardDetails());
        Console.WriteLine(gatheringEvent.FullDetails());
        Console.WriteLine(gatheringEvent.ShortDescription());
    }
}