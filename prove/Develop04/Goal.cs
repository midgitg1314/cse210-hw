using System;
using System.Collections.Generic;

public abstract class Goal
{
    /**protected string Type { get; private set;}
    protected string Name { get; private set;}
    protected string Description { get; private set;}
    protected int Points { get; private set;}**/
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;


    protected Goal(string type, string name, string description, int points)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
    }

    public new string GetType()
    {
        return _type;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public abstract void ListGoal(int i);
    public abstract string SaveGoal();
    public abstract string LoadGoal();
    public abstract void RecordGoalEvent(List<Goal> goals);
}