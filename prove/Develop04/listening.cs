using System;
using System.Collections.Generic;

public class ListingExercise : BaseActivity
{
    private List<string> _prompts = new List<string>
    {
        "Imagince you are in a forest. What do you hear?",
        "Imagine you are at the beach. What do you hear?",
        "Imagine you are in a city. What do you hear?",
        "Imagine you are in a library. What do you hear?",
        "Imagine you are in a park. What do you hear?"
    };

    public ListingExercise()
        : base("Listening Exercise", "This activity is meant for you to listen to the world around you.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.Clear();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.Write("you may begin in:");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        List<string> items = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        DisplayEndingMessage();
    }

}