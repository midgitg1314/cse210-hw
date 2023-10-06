/*
using System.Globalization;

public class Journal{
    public string JournalName { get; set; }
    public List<Entry> Entries { get; set; }

    public Journal(){
        Entries = new List<Entry>();
        
    }

}
*/
using System.Collections.Generic;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response, string date)
    {
        Entry entry = new Entry();
        entry.Prompt = prompt;
        entry.Response = response;
        entries.Add(entry);
    }

        public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            System.Console.WriteLine($"Date: {entry.EntryDate}");
            System.Console.WriteLine($"Prompt: {entry.Prompt}");
            System.Console.WriteLine($"Response: {entry.Response}");
            System.Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.EntryDate.ToShortDateString()},{entry.Prompt},{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear(); // Clear existing entries

        if (System.IO.File.Exists(filename))
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string date = parts[0];
                        string prompt = parts[1];
                        string response = parts[2];
                        AddEntry(prompt, response, date);
                    }
                }
            }
        }
    }
}