using System;

class Program
{
    // I added a way where the person could level up and get points! They are trying to get to 1000 points!!!
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
    
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("WELCOME TO THE ETERNAL QUEST PROGRAM!");
            Console.WriteLine("The more goals you complete the more points you get, try to see if you can get to 1000 points and unlock: THE ULTIMATE SUPER MAUI");
            var levelInfo = manager.GetLevelInfo();
            Console.WriteLine();
            Console.WriteLine($"\nYou have {manager.GetScore()} points. \n");
            Console.WriteLine($"Level {levelInfo.level}: {levelInfo.title}");
            Console.WriteLine();

            Console.WriteLine("THESE ARE YOUR OPTIONS:");
            Console.WriteLine("1. Create a goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record an event");
            Console.WriteLine("6. Quit");

            Console.Write("WHAT GOAL ARE YOU DOING TO CREATE: ");


            string input = Console.ReadLine();
            int choice;
            if (int.TryParse(input, out choice))
            {
                Console.WriteLine();
                switch(choice)
                {
                    case 1:
                        manager.CreateGoal();
                        break;
                    case 2:
                        manager.ListGoals();
                        break;

                    case 3:
                     Console.Write("THE NAME OF YOUR FILE WILL BE: ");
                        string saveFilename = Console.ReadLine();
                        manager.SaveGoals(saveFilename);
                        break;
                    case 4:
                        Console.Write("What is the filename for your goals?:");
                        string loadFilename = Console.ReadLine();
                        manager.LoadGoals(loadFilename);
                        break;
                    case 5:
                        Console.WriteLine("The Goals are:");
                        manager.ListGoals();
                        Console.Write("Which goal did you complete?:");
                        if (int.TryParse(Console.ReadLine(), out int goalIndex))
                        {
                            manager.RecordEvent(goalIndex -1);
                        }
                        break;
                    case 6:
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Not a valid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Input not valid. Please enter another number.");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Thank you for playing the Eternal Quest Program!");
    }
}