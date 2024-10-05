using System;

class Word
{

    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        if (_isHidden == false)
        {
            return _text;
        }
        else
        {
            // https://www.w3schools.com/cs/cs_strings_concat.php#:~:text=You%20can%20also%20use%20the%20string.Concat()
            // https://dotnettutorials.net/lesson/linq-repeat-method/#:~:text=The%20Enumerable.Repeat%20method%20in%20C#%20LINQ
            string renderedWord = string.Concat(Enumerable.Repeat("_", _text.Length));
            return renderedWord;
        }
    }
}