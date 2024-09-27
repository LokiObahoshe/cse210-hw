using System;

public class Entry
{

    public string _promptText;
    public string _date;
    public string _entryText;

    public string Display()
    {
        string _entry = @$"> Date: {_date} - Prompt: {_promptText} - Answer: {_entryText}";
        Console.WriteLine();
        return _entry;
    }
}
