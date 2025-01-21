using System;

public class Resume
{
    public string _firstName;
    public List<Job> _job = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_firstName}");
        Console.WriteLine($"Jobs:");
    

        foreach (Job job in _job)
        {
            job.Display();
        }
    }
}       