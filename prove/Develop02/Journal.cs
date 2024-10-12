using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach(Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}|{e._promptText}|{e._entryText}");
            }
        }
        Console.WriteLine("*** Journal Saved to File ***");
    }

    public void LoadFromFile(string file)
    {        
        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');

                Entry newEntry = new Entry();
                newEntry._date = parts[0];
                newEntry._promptText = parts[1];
                newEntry._entryText = parts[2];
            
                _entries.Add(newEntry);
            }
            Console.WriteLine("*** Journal Loaded from File ***");
        }
    }
}