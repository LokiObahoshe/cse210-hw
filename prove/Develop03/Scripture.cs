using System;

class Scripture
{

    private Reference _reference;
    private List<Word> _words = new List<Word>();



    public Scripture(Reference reference, string script)
    {
        _reference = reference;
        string[] splits = script.Split(" ");
        foreach (string split in splits)
        {
            Word word = new Word(split);
            _words.Add(word);
        }
    }
    
    public void HideRandomWords()
    {
        int number;
        for (int i = 0; i < 3; i++)
        {
            while(true)
            {
                Random randomGenerator = new Random();
                number = randomGenerator.Next(0, _words.Count);
                Word word = _words[number];
                if (word.isHidden() == false)
                {
                    word.Hide();
                    break;
                }
            }
        }
    }

    public void GetDisplayText()
    {
        Console.WriteLine(_reference.GetDisplayText());
        foreach(Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
    }

    public bool IsCompletelyHidden()
    {
        int count = 0;
        foreach(Word word in _words)
        {
            if (word.isHidden() == true)
            {
                count++;
                //https://teamtreehouse.com/community/return-count-1-vs-return-count#:~:text=count%20+%201%20doesn't%20affect%20the%20value%20of
            }
        }
        if (count == _words.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}