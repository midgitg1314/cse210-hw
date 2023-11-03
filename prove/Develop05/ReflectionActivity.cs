class ReflectionActivity : Activity
{
    string[] prompts = new string[]
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        string[] questions = new string[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    public ReflectionActivity(int duration) : base("Reflection", "This activity will help you reflect on times when you have shown strength and resilience.", duration)
    {
    }
    public void Start()
    {
        base.Start();

        Console.WriteLine("Let's begin the reflection exercise...");
    
        Random random = new Random();

        for (int i = 0; i < _duration; i++)
            {
                string prompt = prompts[random.Next(prompts.Length)];
                Console.WriteLine(prompt);

                foreach(var question in questions)
                {
                    Console.WriteLine(question);
                    Thread.Sleep(3000);
                }
            }
            
        base.End();
    }
}