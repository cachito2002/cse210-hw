public class EternalGoal : Goals
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }
    
    public override bool IsComplete()
    {
        return false; // Eternal Goals are never completed
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override string GetDetailString()
    {
        return $"[ ] {_name} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal: {_name}, {_description},{_points}";
    }
}