using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

public class BreathingExercise : BaseActivity
{
    public BreathingExercise() 
        : base ("Breathing Exercise", "This activity is meant for you to relax and breathe in and out.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready to begin breathing...");
        ShowAnimation(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
           
            Console.WriteLine("Breathe out...");
            ShowCountDown(6);
            
            Console.WriteLine();
        }
        DisplayEndingMessage();
    } 
}