using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        
        GoalManagement goals = new GoalManagement();


        Console.Write("\n*** Welcome to the Eternal Quest Program ****\n");
        
        Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");

        MainMenu choice = new MainMenu();
        GoalMenu goalChoice = new GoalMenu();

        int action = 0;

        while (action != 6)
        {
            action = choice.UserChoice();

            switch (action)
            {
                case 1:
                    //CreateNewGoal(goals, textInfo, goalChoice);
                    int goalInput = 0;
                    while (goalInput != 5)
                    {
                        goalInput = goalChoice.GetGoalChoice();
                        switch (goalInput)
                        {
                            case 1:
                                Console.WriteLine("What is the name of your goal? ");
                                string name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal? ");
                                string description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal? ");
                                int points = int.Parse(Console.ReadLine());
                                SimpleGoal sGoal = new SimpleGoal("Simple Goal:", name, description, points);
                                goals.AddGoal(sGoal);
                                goalInput = 5;
                                break;
                            case 2:
                                TryClearConsole();
                                Console.WriteLine("What is the name of your goal? ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal? ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal? ");
                                points = int.Parse(Console.ReadLine());
                                EternalGoal eGoal = new EternalGoal("Eternal Goal:", name, description, points);
                                goals.AddGoal(eGoal);
                                goalInput = 5;
                                break;
                            case 3:
                                Console.WriteLine("What is the name of your goal? ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal? ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal? ");
                                points = int.Parse(Console.ReadLine());
                                int numberTimes = int.Parse(Console.ReadLine());
                                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                                Console.Write("What is the bonus for accomplishing it that many times? ");
                                int bonusPoints = int.Parse(Console.ReadLine());
                                ChecklistGoal clGoal = new ChecklistGoal("Check List Goal:", name, description, points,numberTimes, bonusPoints);
                                goals.AddGoal(clGoal);
                                goalInput = 5;
                                break;
                            case 4:
                                Console.WriteLine("What is the name of your goal? ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal? ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal? ");
                                points = int.Parse(Console.ReadLine());
                                NegativeGoal nGoal = new NegativeGoal("Negative Goal:", name, description, points);
                                goals.AddGoal(nGoal);
                                goalInput = 5;
                                break;
                            case 5:
                                break;
                            case 6:
                                Console.WriteLine($"\nThank you for using the Eternal Quest Program!\n");
                                break;
                            default:
                                Console.WriteLine($"\nSorry the option you entered is not valid.");
                                break;
                        }
                    }
                    break;
                case 2:
                    TryClearConsole();
                    Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
                    goals.ListGoals();
                    break;
                case 3:
                    goals.SaveGoals();
                    break;
                case 4:
                    TryClearConsole();
                    Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
                    goals.LoadGoals();
                    break;
                case 5:
                    TryClearConsole();
                    Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
                    goals.RecordGoalEvent();
                    break;
                case 6:
                    Console.WriteLine("\nThank you for using the Eternal Quest Program!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
    static void TryClearConsole()
    {
        try
        {
            Console.Clear(); // Try to clear the console using the built-in method
        }
        catch (IOException)
        {
            // Handle IOException if Console.Clear() fails
            ClearConsoleFallback();
        }
    }
static void ClearConsoleFallback()
    {
        if (!Console.IsOutputRedirected)
        {
            // Simulate clearing by printing newlines
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.WriteLine(new string(' ', Console.WindowWidth));
            }
            Console.SetCursorPosition(0, 0);
        }
    }
}

    /**static void CreateNewGoal(GoalManagement goals, TextInfo textInfo, GoalMenu goalChoice)
    {
        int goalInput = 0;

        while (goalInput != 5)
        {
            goalInput = goalChoice.GoalChoice();

            switch (goalInput)
            {
                case 1:
                case 2:
                case 4:
                    AddGoal(goals, textInfo, goalInput);
                    goalInput = 5;
                    break;
                case 3:
                    AddChecklistGoal(goals, textInfo);
                    goalInput = 5;
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }

    static void AddGoal(GoalManagement goals, TextInfo textInfo, int goalType)
    {
        Console.WriteLine($"What is the name of your goal?  ");
        string name = textInfo.ToTitleCase(Console.ReadLine());
        Console.WriteLine($"What is a short description of your goal?  ");
        string description = textInfo.ToTitleCase(Console.ReadLine());
        Console.Write($"What is the amount of points associated with this goal?  ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case 1:
                goals.AddGoal(new SimpleGoal("Simple Goal:", name, description, points));
                break;
            case 2:
                goals.AddGoal(new EternalGoal("Eternal Goal:", name, description, points));
                break;
            case 4:
                goals.AddGoal(new NegativeGoal("Negative Goal:", name, description, points));
                break;
            default:
                Console.WriteLine($"\nInvalid goal type.");
                break;
        }
    }

    static void AddChecklistGoal(GoalManagement goals, TextInfo textInfo)
    {
        Console.WriteLine($"What is the name of your goal?  ");
        string name = textInfo.ToTitleCase(Console.ReadLine());
        Console.WriteLine($"What is a short description of your goal?  ");
        string description = textInfo.ToTitleCase(Console.ReadLine());
        Console.Write($"What is the amount of points associated with this goal?  ");
        int points = int.Parse(Console.ReadLine());
        Console.Write($"How many times does this goal need to be accomplished for a bonus?  ");
        int numberTimes = int.Parse(Console.ReadLine());
        Console.Write($"What is the bonus for accomplishing it that many times?  ");
        int bonusPoints = int.Parse(Console.ReadLine());
        goals.AddGoal(new ChecklistGoal("Check List Goal:", name, description, points, numberTimes, bonusPoints));
    }

    static void ListGoals(GoalManagement goals)
    {
        Console.Clear();
        Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
        goals.ListGoals();
    }

    static void LoadGoals(GoalManagement goals)
    {
        Console.Clear();
        Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
        goals.LoadGoals();
    }

    static void RecordEvent(GoalManagement goals)
    {
        Console.Clear();
        Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
        goals.RecordGoalEvent();
    }
}**/