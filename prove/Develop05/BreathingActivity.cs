class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.", duration)
    {
    }
    public void Start()
    {
        base.Start();

        Console.WriteLine("Let's begin the breathing exercise...");
        
        for (int i = 0; i < _duration; i++)
        {
            Console.WriteLine(i % 2 == 0 ? "Breathe in..." : "Breathe out...");
            Thread.Sleep(1000);
        }
        base.End();
    }
}