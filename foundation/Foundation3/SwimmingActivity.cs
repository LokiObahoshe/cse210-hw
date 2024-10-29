using System;

public class SwimmingActivity : Activity
{
    private double _numberOfLaps;
    public SwimmingActivity(string date, int minutes, double numberOfLaps) : base(date, minutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }

    public override double GetPace()
    {
        return _minutes / (double)GetDistance();
    }
}