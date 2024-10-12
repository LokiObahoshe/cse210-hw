using System;

class Comment {

    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public string GetComment()
    {
        return _text;
    }

    public string GetName()
    {
        return _name;
    }
}