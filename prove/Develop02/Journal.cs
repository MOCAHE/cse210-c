using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntries();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter ouputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                ouputFile.WriteLine($"{entry._date} - {entry._promptText}");
                ouputFile.WriteLine($"{entry._entryText}");
                ouputFile.WriteLine();
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        using (StreamReader inputFile = new StreamReader(fileName))
        {
            string linea = "";

            while ((linea = inputFile.ReadLine()) != null)
            {
                if (linea.Contains("-"))
                {
                    string[] parts = linea.Split("-");
                    string date = parts[0].Trim();
                    string promptText = parts[1].Trim();

                    Entry newEntry = new Entry();
                    newEntry._date = date;
                    newEntry._promptText = promptText;
                    _entries.Add(newEntry);
                }
                else if (_entries.Count > 0)
                {
                    Entry lastEntry = _entries[_entries.Count - 1];
                    lastEntry._entryText += linea + "\n";
                }
            }
        }
    }
}
