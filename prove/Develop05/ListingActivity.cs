class ListingActivity : Activity
{
    private string[] listPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected override void DisplayStartingMessage()
    {
        Console.WriteLine("Listing Activity");
        Console.WriteLine("This Activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
    }

    protected override void RunActivity()
    {
        Random random = new Random();
        string prompt = listPrompts[random.Next(listPrompts.Length)];
        Console.WriteLine(prompt);

        Console.WriteLine("You have {o} seconds to start listing...", Duration);
        Thread.Sleep(3000);

        Console.WriteLine("Go!");

        for (int i= 0; i < Duration; i++)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
        }
    }
    protected override void DisplayEndingMessage()
    {
        Console.WriteLine("Good Job! ");
    }
}