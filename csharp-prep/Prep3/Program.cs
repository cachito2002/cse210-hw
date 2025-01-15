using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("THIS IS PREP3 ASSIGNMENT!!!");


       Random randomNumber = new Random();
       int y = randomNumber.Next(1,10);

        int x = -1;

        while (y != x)
    
        { 
            Console.Write("What is your guess? ");
            string num = Console.ReadLine();
            x = int.Parse(num);
                if (y == x)
                {
                    Console.WriteLine("You got it right!!!");
                }
                else if (x > y)
                {
                    Console.WriteLine("Guess a little lower!");
                }
                else if (x < y)

                {
                    Console.WriteLine("Guess a little higher");
                }
                else
                {
                    Console.WriteLine("That is not a number or a correct guess");
                }
        }
        Console.Write("Thank you for playing!");

    }
}