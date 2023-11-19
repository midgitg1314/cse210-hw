
public class SimpleGoal : Goal
{
    public SimpleGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        
    }

    public bool Status {get; private set;}

    public override void ListGoal(int i)
    {
        //string statusSymbol = Status ? "[X]" : "[ ]";
        Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
    }

    public override string SaveGoal()
    {
        return $"{GetType()}; {GetName()}; {GetDescription()}; {GetPoints()}";
    }

    public override string LoadGoal()
    {
        return $"Simple Goal:; {GetName()}; {GetDescription()}; {GetPoints()}";
    }

    public override void RecordGoalEvent(List<Goal> goals)
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }
}