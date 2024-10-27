using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted = 0, bool isComplete = false) : base(name, description, points, isComplete)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public int Bonus
    {
        get { return _bonus; }
    }

        public override void RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted >= _target)
        {
            _isComplete = true;
        }

        /*
        if (!_isComplete)
        {
            _amountCompleted++;

            if (_amountCompleted >= _target)
            {
                _isComplete = true;
            }
            else
            {
                _isComplete = false;
            }
        }
        else
        {
            Console.WriteLine("Goal already completed.");
            return;
        }
        */
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailString()
    {
        string mark = _isComplete ? "X" : " ";
        return $"[{mark}] {_shortName} ({_description}) - Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"{this.GetType().Name},{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted},{_isComplete}";
    }
}