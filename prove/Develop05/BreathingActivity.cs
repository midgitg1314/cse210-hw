class BreathingActivity : Activity
{
    protected override void DisplayStartingMessage()
    {
        Console.WriteLine("Breathing Activity");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
    }

    protected override void RunActivity()
    {
        for (int i=0; i < Duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000);
        }
    }

    protected override void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You have completed the Breathing Activity for {0} seconds.", Duration);
    }

}