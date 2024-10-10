using System;

class Video {

    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string _name, string _text)
    {
        Console.WriteLine();
    }

    public void NumberOfComments()
    {
        Console.WriteLine("W.I.P")
    }

    public string GetDisplayText()
    {
        Console.WriteLine("WOOOOOO");
    }
}