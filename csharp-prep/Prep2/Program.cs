using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("What is your Grade percentage? ");
       string gradePercentage = Console.ReadLine();
       string letter;
       int x = int.Parse(gradePercentage);

    

       if (x >= 90)
       {
            letter = "A";
            Console.WriteLine($"Grade: {letter}");
       }
       else if (x >= 80)
       {
            letter = "B";
            Console.Write($"{letter}");
       }
       else if (x >= 70)
       {
            letter = "C";
            Console.Write($"{letter}");
       }
       else if (x >= 60)
       {
            letter = "D";
            Console.Write($"{letter}");
       }
       else
       {
            letter = "F";
            Console.WriteLine($"{letter}");
       }

       if (x >= 70 )
       {
            Console.WriteLine("You did amazing this semester, you passed the class! See you next time!!");
       }
       else
       {
            Console.WriteLine("Good Luck next time dude, you did not pass, you will have to retake the class!!!");
       }
       



    

        
    }
}