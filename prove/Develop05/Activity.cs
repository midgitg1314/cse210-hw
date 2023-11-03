class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void Start()
    {
        Console.WriteLine($"Activity: {_name}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000);
    }
    
    public void End()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"{_name} activity completed.");
        Console.WriteLine($"Duration: {_duration} seconds");
        Thread.Sleep(3000);
    }
}