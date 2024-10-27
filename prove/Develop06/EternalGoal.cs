using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points, bool isComplete = false) : base (name, description, points, isComplete){}

    public override void RecordEvent() {}
    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{this.GetType().Name},{_shortName},{_description},{_points},{_isComplete}";
    }
}