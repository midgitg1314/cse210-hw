/*
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal program!");
        
        int choice = 0;
        DateTime theCurrentTime = DateTime.Now;
        Entry entry = null;
        while (choice != 5){
            Console.WriteLine("Please select ond of the following choices: 1. Write 2. Display 3. Load 4. Save  5. Quit");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1 || choice == 2 || choice == 3 || choice == 4){
                if (choice == 1){
                    Entry entry = new Entry();
                    entry.Prompt = "";
                    entry.Response = "";
                }
                else if (choice == 2){
                    Console.WriteLine("Journal Entries:");
                    foreach (var journalEntry in journal.Entries)
                    {
                        Console.WriteLine($"Prompt: {journalEntry.Prompt}");
                        Console.WriteLine($"Response: {journalEntry.Response}");
                    }
                    //Journal journal = new Journal();
                    //journal.JournalName = "";
                    //journal.Entries = new List<Entry>(); // he did move this code to the journal class
                    //journal.Entries.Add(entry);
                }
                else if (choice == 3){

                }
                else if (choice == 4){

                }
            }
            else {
                Console.WriteLine("Please select option 1, 2, 3, 4 or 5");
                choice = int.Parse(Console.ReadLine());
            }
        }
    }
}
//If user picks option to add a new entry
//1. Pick a random prompt from list above
//2. Display random prompt 
//3. save response from user
//4. create response object
//5. Save response object to journal object

//5.

*/
using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        Random random = new Random();

        int choice = 0;
        
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Quit");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 1)
                {
                    string[] prompts = Prompts.GetPrompts();
                    string randomPrompt = prompts[random.Next(prompts.Length)];

                    Console.WriteLine("Your prompt for today: " + randomPrompt);
                    Console.WriteLine("Enter your response:");
                    string response = Console.ReadLine();
                    string currentDate = DateTime.Now.ToShortDateString();

                    journal.AddEntry(randomPrompt, response, currentDate);
                }
                else if (choice == 2)
                {
                    journal.DisplayEntries();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Enter the filename to save the journal:");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Enter the filename to load the journal:");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number (1-5).");
            }
        }
    }
}