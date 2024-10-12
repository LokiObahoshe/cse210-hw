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
        Comment comment = new Comment(_name, _text);
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public string GetDisplayText()
    {
        string result = $"\n------------------\n\nTitle: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nNumber of Comments: {NumberOfComments()}";

        if (NumberOfComments() > 0)
        {
            result += "\n\nComments:\n";
            foreach (var comment in _comments)
            {
                result += $"\n{comment.GetName()}: {comment.GetComment()}";
            }
        }
        return result;
    }

    public override string ToString()
    {
        return GetDisplayText();
    }
}