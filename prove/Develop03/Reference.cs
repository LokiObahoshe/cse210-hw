using System;

class Reference
{

    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;
    //https://www.w3schools.com/cs/cs_conditions_shorthand.php
    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
    
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        //After looking at some websites that go over this "value"
        //code, it's checking if endVerse is null (empty)
        //or has a value.

        if (_endVerse.HasValue)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse.Value}";
        }
        return $"{_book} {_chapter}:{_verse}";
    }
}