using System;
using System.Collections.Generic;

public class ReflectionExercise : BaseActivity
{
    private List<string> _prompts = new List<string>
    {
        "What are you grateful for today?",
        "What is something you learned today?",
        "What is something you want to improve on?",
        "What is something you want to accomplish tomorrow?",
        "What is something you want to let go of?"
    };

    private List<string> _questions = new List<string>
    {
        "Why is the Gospel important to you?",
        "What is your favorite scripture?",
        "What is your favorite hymn?",
        "What is your favorite temple?",
        "What is your favorite prophet?"
    };

    public ReflectionExercise()
        : base("Reflection Exercise", "This activity is meant for you to reflect on your day and think about your goals.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine("Reflect on the following prompt:");
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        
        int questionIndex = 0;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(_questions[questionIndex %_questions.Count]);
            ShowAnimation(10);
            Console.WriteLine();
            questionIndex++;
        }
        DisplayEndingMessage();
    }

}