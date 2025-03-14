public class SimpleGoal : Goals
{
    
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)

    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool isComplete)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override string GetDetailString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description})";
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {_name}, {_description}, {_points}, {_isComplete}";
    }
}