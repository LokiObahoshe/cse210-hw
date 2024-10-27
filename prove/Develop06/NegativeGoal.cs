using System;

public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, string points, bool isComplete = false) : base(name, description, points, isComplete){}

    public override void RecordEvent() {}

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"{this.GetType().Name},{_shortName},{_description},{_points},{_isComplete}";
    }
}