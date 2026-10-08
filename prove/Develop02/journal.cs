using System;
using System.Collections.Generic;

namespace Develop02.obj;

public class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();


    public void SaveToJournal()
    {
        JournalEntry entry = new JournalEntry();
        entry.CreateJournalEntry();
        _entries.Add(entry);
    }

    public void DisplayLatest()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet.");
            return;
        }
        _entries[_entries.Count - 1].DisplayEntry();
    }

    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries)
            {
                outputFile.WriteLine(entry.ToFileString());
            }
        }
    }

    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            JournalEntry entry = new JournalEntry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            _entries.Add(entry);

            entry.DisplayEntry();
        }
    }
}
    

