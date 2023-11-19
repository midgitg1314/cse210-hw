using System;
using System.Collections.Generic;
public class EternalGoal : Goal
{
/**private const string Type = "Eternal Goal";
    private bool _status; **/

    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
    
    }
    
    //public bool Status {get; private set;}
    /**
    public EternalGoal(string name, string description, int points, bool status) : base(Type, name, description, points)
    {
        _status = status;
    }

**/
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
        return $"{GetType()}; {GetName()}; {GetDescription()}; {GetPoints()}";
    }

    public override void RecordGoalEvent(List<Goal> goals)
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }
}