using System;

class Program
{
    static void Main(string[] args)
    {
       bool running = true;

       while (running)
       {
            Console.Clear();
            Console.WriteLine("WELCOME, TO YOUR SPACE OF PEACE.");
            Console.WriteLine("The following options are for you to meditae and think.");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection Exercise");
            Console.WriteLine("3. Listening Exercise");
            Console.WriteLine("4. Exit");
            Console.WriteLine("\nSelect a choice from the menu: ");

            string choice = Console.ReadLine();
            
            switch(choice)
            {
                case "1":
                    BreathingExercise breathing = new BreathingExercise();
                    breathing.Run();
                    break;
                case "2":
                    ReflectionExercise reflection = new ReflectionExercise();
                    reflection.Run();
                    break;
                case "3":
                    ListingExercise listing = new ListingExercise();
                    listing.Run();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Have an amazing day you are doing amazing! God is with you, he will always be with you!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}