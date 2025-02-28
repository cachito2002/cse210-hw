using System;

class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("WELCOME, TO YOUR SPACE OF PEACE.");
        Console.WriteLine("The following options are for you to meditae and think.");
        Console.WriteLine("1. Breathing Exercise");
        Console.WriteLine("2. Reflection Exercise");
        Console.WriteLine("3. Listening Exercise");

        string choice = Console.ReadLine();
        bool running = true;
        while (running)
        switch(choice)
        {
            case "1":
                // BreathingExercise();
                Console.WriteLine("You lit.");
                break;
            case "2":
                // ReflectionExercise();
                break;
            case "3":
                // ListeningExercise();
                break;
            default:
                Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                break;
        }
    }
}