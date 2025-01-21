using System;

public class Job
{
    public string _jobTitle;
    public string _companyTitle;
    public double _startYear;
    public double _endYear;

    public Job()
    {
    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyTitle}) {_startYear}-{_endYear}");
        
    }
}