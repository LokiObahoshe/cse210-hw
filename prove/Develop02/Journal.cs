using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No new entries to display.");
            return;
        }
        else
        {
            foreach (Entry ent in _entries)
            {
                Console.WriteLine(ent.Display());
            }
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (Entry ent in _entries)
            {
                outputFile.WriteLine(ent.Display());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            //string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                Console.WriteLine();
                Console.WriteLine(parts[0]);

                /*
                if (parts.Length == 3) // Check if the line has 3 parts
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0].Trim(),
                        _promptText = parts[1].Trim(),
                        _entryText = parts[2].Trim()
                    };
                    _entries.Add(entry); // Add the entry to the journal
                }
                else
                {
                    Console.WriteLine($"An error occured");
                }
                */
            }
        }
        else
        {
            Console.WriteLine("\nFile does not exist.");
        }
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
}