/*
using System;

class Prompts
{
    static void Main()
    {
        string[] prompts = new string[]{
            "What happened today?",
            "What was the best thing that happened today?",
            "What was the worst thing that happened today?",
            "What was the most interesting thing I saw or heard today?",
            "What was the most challenging thing I faced today?",
            "What am I grateful for today?",
            "What did I learn today?",
            "What was the most fun thing I did today?",
            "What was the most surprising thing that happened today?",
            "What did I do today that I am proud of?",
        };

        Random random = new Random();
        int randomIndex = random.Next(0, prompts.Length);
        string randomString = prompts[randomIndex];

        Console.WriteLine(randomString);
    }
}
*/
using System;

public static class Prompts
{
    public static string[] GetPrompts()
    {
        return new string[]
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }
}