using System;

public class MainMenu
{
    private string _menu = $@"
Main Menu Options
====================================================
Please select one of the following options:
1. Create New Goal
2. List Goals
3. Save Goal
4. Load Goal
5. Record Goal Event
6. Quit
====================================================
Select an option from the menu: ";

    public string _userInput;
    public int _userChoice = 0;
    
    public int UserChoice()
    {
        Console.Write(_menu);

        _userInput = Console.ReadLine();
        _userChoice = 0;

        try
        {
            _userChoice = int.Parse(_userInput);
        }
        catch (FormatException)
        {
            _userChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Unexpected error: {exception.Message}");
        }

        return _userChoice;
    }
}