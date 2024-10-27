using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;
    protected bool _isComplete;

    public Goal(string name, string description, string points, bool isComplete = false)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public string Points
    {
        get { return _points; }
    }

    public string GetName()
    {
        return _shortName;
    }

    public abstract void RecordEvent();

    public virtual bool IsComplete()
    {
        return _isComplete;
    }
    public virtual string GetDetailString()
    {
        string mark = _isComplete ? "X" : " ";

        if (this is NegativeGoal)
        {
            return $"[{mark}] {_shortName} ({_description}) -- Negative Goal";
        }
        else
        {
            return $"[{mark}] {_shortName} ({_description})";
        }
    }

    public virtual string GetStringRepresentation()
    {
        return $"{this.GetType().Name},{_shortName},{_description},{_points},{_isComplete}";
    }
}