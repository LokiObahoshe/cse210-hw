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
            /*using (StreamReader streamReader = File.OpenText(filename))
            {
                string textFound;

                while ((textFound = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(textFound);
                }
            }*/

            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                Console.WriteLine();
                Console.WriteLine(parts[0]);
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("File not found. Please try again.");
        }
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
}