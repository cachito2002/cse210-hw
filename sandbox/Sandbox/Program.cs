using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Brigham", "21");
        string name = student.GetName();
        string number = student.GetNumber();

        Console.WriteLine("Enter the animation duration in seconds: ");
        if (!int.TryParse(Console.ReadLine(), out int duration) || duration <= 0) 
        {
            
            Console.WriteLine("Invalid input. Exiting program.");
            duration = 10;
        }



        // |/-\|/-\
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-"); 
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        

        // foreach (string s in animationStrings)
        // {
        //     Console.WriteLine(s);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }


        int i = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }

        }
        
    }

}
    
        // Thread.Sleep(1000);
        // Console.WriteLine(name);
        // Console.WriteLine(number);
        // static void DisplayMessage()
        // {
        //     Console.Write("Welcome Player 1");
        // }

        // static string UserName()
        // {
        //     Console.Write("Please enter your name: ");
        //     string name = Console.ReadLine();
        //     return name;
        // }

        // static int UserNumber()
        // {
        //     Console.Write("What is your favorite number? ");
        //     int number = int.Parse(Console.ReadLine());
        //     return number;
        // }

        // static int SquareNumber(int number)
        // {
        //     int square = number * number;
        //     return square;
        // }

        // static void DisplayResult(string name, int square)
        // {
        //     Console.Write($"{name}, this is your number squared {square}");
        // }
        // Console.WriteLine("Hello Sandbox World! bruh");
        // Console.WriteLine("What is up goody");

        // int number = 5;
        // number = 8;
        // number = number + 3;
        
        // Console.Write("What is your favorite color? ");
        // string color = Console.ReadLine();
        // Console.WriteLine($"Your color is {color}");
        // Console.Write("Enter number: ");
        // string valueFromUser = Console.ReadLine();

        // int x = int.Parse(valueFromUser);
        // int y = 2;
        // int z = 5;
        // if (x > y && y < z)
        // {
        //     Console.WriteLine("Greater");
        // }
        // else if (x != y)
        // {
        //     Console.WriteLine("Less");
        // }
        // else
        // {
        //     Console.WriteLine("Bruh non of the above");
        // }

    