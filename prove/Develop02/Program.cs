using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void DisplaySavedFiles()
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string[] files = Directory.GetFiles(currentDirectory, "*.txt");

        if (files.Length == 0)
        {
            Console.WriteLine("No files found.");
            return;
        }

        Console.WriteLine("Files found:");
        foreach (string file in files)
        {
            string fileName = Path.GetFileName(file);
            Console.WriteLine(fileName);
        }
    }
    static void Main(string[] args)
    { 
        Journal journal = new Journal();
        List<string> prompts = new List<string>()
        {
            "What is a miracle that you have seen today?",
            "What is something that you are grateful for today?",
            "How have you seen God's hand in your life today?",
            "If you were to say something nice to someone today, what would it be?",
            "What words would you use to describe the love of your life?"
        };
        bool running = true;
        while (running)
    {
        Console.WriteLine("WELCOME TO YOUR JOURNAL; CHOOSE ONE OF THE FOLLOWING:");
        Console.WriteLine("1.Write in Journal.");
        Console.WriteLine("2.Display Journal.");
        Console.WriteLine("3.Save File");
        Console.WriteLine("4.Load File");
        Console.WriteLine("5.Display Saved Files");
        Console.WriteLine("6.Quit");

        string choice = Console.ReadLine();
        switch (choice)

        {
            case "1":
               Random rand = new Random();
               string prompt = prompts[rand.Next(prompts.Count)];
               Console.WriteLine(prompt);
               string response = Console.ReadLine();
               string date = DateTime.Now.ToShortDateString();
               string time = DateTime.Now.ToShortTimeString();
               Entry newEntry = new Entry(prompt, response, date + " " + time);
               journal.AddEntry(newEntry);
               break;

            case "2":
                journal.DisplayEntries();
                break;

            case "3":
                Console.WriteLine("Enter the file name to save:");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
                break;
            
            case "4":
                Console.WriteLine("Enter the file name to load:");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
                break;

            case "5":
                Console.WriteLine("These are your files:");
                DisplaySavedFiles();
                break;

            case "6":
                Console.WriteLine("See you very soon!");
                running = false;
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
            }              
        }
    } 
}