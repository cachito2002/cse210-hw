using System.Dynamic;
using System.Runtime.CompilerServices;

public abstract class Goals
{
    protected string _name;
    protected int _points;
    protected string _description;


    public Goals(string name, string description, int points)
    {
        _name = name;
        _points = points;
        _description = description;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public abstract bool IsComplete();  
    public abstract int RecordEvent();
    public abstract string GetDetailString();
    public abstract string GetStringRepresentation();
}

