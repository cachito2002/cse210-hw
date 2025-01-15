using System;

class Program
{
    static void Main(string[] args)
    {
        //    This is the main section
        Console.WriteLine("PREP5");
        DisplayMessage();
        string name = AskName("Please enter your name: ");
        int number = AskNumber("Please enter your favorite number: ");
        EndResult();

    }
    //    These are the functions
    static void DisplayMessage()
    {
    Console.WriteLine($"Hello World");
    }
    
    static string AskName (string prompt)
    {
        Console.Write(prompt);
        string userInput = Console.ReadLine();
        return userInput;
    }

    static int AskNumber(string prompt)
    {
        Console.Write(prompt);
        string userInput = Console.ReadLine();
        int userNumber = Convert.ToInt32(userInput);
        return userNumber;

    static void EndResult(string name, int number)
    {
    int squared =  number * number;
    Console.WriteLine($"{name}, the square of your number is {squared}.");
    }

}