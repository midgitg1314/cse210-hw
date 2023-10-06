// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
/*
using System.IO; 

DateTime theCurrentTime = DateTime.Now;
string dateText = theCurrentTime.ToShortDateString();
public class Entry{

    string journalFile = "journalFile.txt";
    public DateTime EntryDate {get; set;} //teachers code.
    public string Prompt {get; set;}//teachers code.
    public string Response {get; set;}//teachers code.
    public void WriteEntry(string prompt, string dateText)
    {
        using (StreamWriter outputFile = new StreamWriter(journalFile))
        {

            // You can add text to the file with the WriteLine method
            outputFile.WriteLine($"Date: {dateText} - Prompt: ");
            
            // You can use the $ and include variables just like with Console.WriteLine
            outputFile.WriteLine($"My favorite color is {dateText}");
        }
    }
}
*/
using System;

public class Entry
{
    public DateTime EntryDate { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry()
    {
        EntryDate = DateTime.Now;
        Prompt = "";
        Response = "";
    }

    public void WriteEntry()
    {
        string journalFile = "journalFile.txt";

        using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(journalFile, true)) // Use 'true' to append to the file
        {
            outputFile.WriteLine($"Date: {EntryDate.ToShortDateString()} - Prompt: {Prompt}");
            outputFile.WriteLine($"Response: {Response}");
        }
    }
}