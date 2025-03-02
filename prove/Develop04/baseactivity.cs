using System;
using System.Threading;
public class BaseActivity
{
    private string _activityName;
    private string _description;
    private int _duration;


    public BaseActivity(string activityName, string description)
        {
            _activityName = activityName;
            _description = description;
            _duration = 30;
        }


    public string GetName()
        {
            return _activityName;
        }
    public int GetDuration()
        {
            return _duration;
        }
    public string GetDescription()
        {
            return _description;
        }
    
    public void SetDuration(int duration)
        {
            _duration = duration;
        }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)
        {
            _duration = duration;
        }
        else
        {
            Console.WriteLine("invalid input. Using default duration of 30 seconds.");
            _duration = 30;
        }

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowAnimation(3);
    }
        public void DisplayEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well Done!!");
            ShowAnimation(3);
            Console.WriteLine();
            Console.WriteLine($"You have completed another {_duration} second of the {_activityName}");
            ShowAnimation(5);
        }

    public void ShowAnimation(int seconds)
    {
        List<string> animationStrings = new List<string> {"|", "/", "-", "\\"};

        Console.Write("Loading ");
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        
        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i% animationStrings.Count]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;
        }
    }
    public void ShowCountDown(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public virtual void Run()
    {
        DisplayStartingMessage();
        DisplayEndingMessage();
    }
}