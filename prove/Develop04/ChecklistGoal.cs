using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;

public class ChecklistGoal : Goal
{
    
    private new string _type = "Checklist Goal";
    private int _numberTimes;
    private int _bonusPoints;
    private bool _status;
    private int _count;

    public ChecklistGoal(string type, string name, string description, int points, int numberTimes, int bonusPoints) : base(type, name, description, points)
    {
        _status = false;
        _numberTimes = numberTimes;
        _bonusPoints = bonusPoints;
        _count = 0;
    }

    /**public bool Status {get; private set;}
    public int numberTimes {get; private set;}
    public int BonusPoints {get; private set;}
    public int Count {get; private set;}**/

    /**public ChecklistGoal(string name, string description, int points, bool status, int targetCount, int bonusPoints, int count) : base(Type, name, description, points, status)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _count = count;
    }
    
    public int targetCount => _targetCount;
    public int BonusPoints => _bonusPoints;
    public int Count => _count;**/

    public override void ListGoal(int i)
    {
        //string statusSymbol = Status ? "[X]" : "[ ]";
        if (!_status)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()}) -- Completed: {_count}/{_numberTimes}");
        }
        else
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()}) -- Currently Completed: {_count}/{_numberTimes}");
        }
    }

    public override string SaveGoal()
    {
        return $"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}; {_numberTimes}; {_bonusPoints}; {_count}";
    }

    public override string LoadGoal()
    {
        return $"Check List Goal:; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}; {_numberTimes}; {_bonusPoints}; {_count}";
    }

    public override void RecordGoalEvent(List<Goal> goals)
    {
        _count++;
        int points = GetPoints();

        if (_count == _numberTimes)
        {
            _status = true;
            points += _bonusPoints;
            
            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        }
    }
}