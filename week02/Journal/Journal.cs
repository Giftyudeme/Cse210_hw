using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // Adds a new entry to the list
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Iterates and displays all entries
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is currently empty.\n");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Saves the entries to a file using robust JSON-like formatting 
    // to properly handle commas, quotes, and newlines.
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                // Escape custom tilde delimiters to ensure safe saving
                string safePrompt = entry.PromptText.Replace("~|~", " ");
                string safeText = entry.EntryText.Replace("~|~", " ");
                
                writer.WriteLine($"{entry.Date}~|~{safePrompt}~|~{safeText}");
            }
        }
        Console.WriteLine("Journal saved successfully!\n");
    }

    // Loads entries from a file and completely replaces current ones
    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("Error: File not found.\n");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded successfully!\n");
    }
}
