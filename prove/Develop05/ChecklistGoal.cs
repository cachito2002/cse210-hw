public class ChecklistGoal : Goals
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;
    
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int timesCompleted)
    : base(name, description, points)
    {
        _timesCompleted = timesCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override bool IsComplete()
    {
        return _timesCompleted >= _target;
    }
    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted == _target)
        {
            return _points + _bonus;
        }
        return _points;
    }

    public override string GetDetailString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description}) -- Currently completed: {_timesCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal: {_name}, {_description}, {_points}, {_target}, {_bonus}, {_timesCompleted}";
    }






}
