using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GoalManagement
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;

    public GoalManagement()
    {
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void AddPoints(int points)
    {
        _totalPoints += points;
    }

    public void AddBonus(int bonusPoints)
    {
        _totalPoints += bonusPoints;
    }

    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }
    
    public List<Goal> GetGoalsList()
    {
        return _goals;
    }

    public void ListGoals()
    {
        if (_goals.Count > 0)
        {
            Console.WriteLine("\nYour Goals are:");

            int index = 1;
            foreach (Goal goal in _goals)
            {
                goal.ListGoal(index);
                index++;
            }
        }
        else 
        {
            Console.WriteLine("\nYou currently have no goals!");
        }
    }

    public void RecordGoalEvent()
    {
        ListGoals();

        Console.WriteLine("\nWhich goal did you accomplish? ");
        int select = int.Parse(Console.ReadLine()) -1;

        int goalPoints = GetGoalsList()[select].GetPoints();
        AddPoints(goalPoints);

        GetGoalsList()[select].RecordGoalEvent(_goals);

        Console.WriteLine($"\n*** You have {GetTotalPoints()} points! ***\n");
    }

    public void SaveGoals()
    {
        Console.WriteLine("\nWhat is the name for this goal file? ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            outputFile.WriteLine(GetTotalPoints());

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }
     
     public void LoadGoals()
     {
        Console.Write("\nWhat is the name of your goal file? ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);

            int totalPoints = int.Parse(readText[0]);
            SetTotalPoints(totalPoints);

            readText = readText.Skip(1).ToArray();

            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                string type = entries[0];
                string name = entries[1];
                string description = entries[2];
                int points = int.Parse(entries[3]);
                //bool status = Convert.ToBoolean(entries[4]);


                if (type == "Simple Goal:")
                {
                    SimpleGoal sGoal = new SimpleGoal(type, name, description, points);
                    AddGoal(sGoal);
                }
                else if (type == "Eternal Goal:")
                {
                    EternalGoal eGoal = new EternalGoal(type, name, description, points);
                    AddGoal(eGoal);
                }
                else if (type == "Check List Goal:")
                {
                    int numberTimes = int.Parse(entries[4]);
                    int bonusPoints = int.Parse(entries[5]);
                    //int counter = int.Parse(entries[7]);
                    ChecklistGoal clGoal = new ChecklistGoal(type, name, description, points, numberTimes, bonusPoints);
                    AddGoal(clGoal);
                }
                else if (type == "Negative Goal:")
                {
                    NegativeGoal nGoal = new NegativeGoal(type, name, description, points);
                    AddGoal(nGoal);
                }
            }
        }
    }
}