class ListingActivity : Activity
{
    public ListingActivity(int duration) : base("Listing", "This activity will help you reflect on the good things in your life by listing items.", duration)
    {
    }
    
    public void Start()
    {
        base.Start();

        Console.WriteLine("Let's begin the listing exercise...");

        string[] prompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();
        int itemCounter = 0;

        for (int i = 0; i < _duration; i++)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);

            for (int j = 5; j >= 1; j--)
            {
            Console.WriteLine($"Item {itemCounter + 1} (in {j}s):");
                itemCounter++;
                Thread.Sleep(1000);
            }
        }

        Console.WriteLine($"NUmber of items listed: {itemCounter}");

        base.End();
    }
}