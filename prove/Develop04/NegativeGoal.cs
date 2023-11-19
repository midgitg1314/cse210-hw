
public class NegativeGoal : Goal
{
    private new string _type = "Negative Goal:";
    private bool _status;

    public NegativeGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _status = false;
    }

    //public bool Status {get; private set;}

    /**public NegativeGoal(string name, string description, int points, bool status) : base(Type, name, DescriptionAttribute, points)
    {
        return _status
    }**/

    public override void ListGoal(int i)
    {
        //string statusSymbol = Status ? "[X]" : "[ ]";
        Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
    }

    public override string SaveGoal()
    {
        return $"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}";
    }

    public override string LoadGoal()
    {
        return $"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}";
    }
    
    public override void RecordGoalEvent(List<Goal> goals)
    {
        Console.WriteLine($"Bummer! you have Lost {GetPoints()} points!");
    }
}