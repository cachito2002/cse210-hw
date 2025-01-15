using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PREP4 ASSIGNMENT!!!");
        List<int> numbers = new List<int>();
        
        int x = -1;

        
        while (x != 0)
        {
            Console.Write("Enter a number, type 0 when finished! ");
            string num = Console.ReadLine();
            x = int.Parse(num);
            

            if (x != 0)
            {
                numbers.Add(x);
            }
        }
            int sum = 0;
            
            foreach (int n in numbers)
            {
                sum += n;

            }
            double average = 0;
            if (numbers.Count > 0)
            {
                average = sum / (double)numbers.Count;
            }
            
            int largest = numbers.Max();

                Console.WriteLine($"The sum of the numbers is: {sum}");
                Console.WriteLine($"The average of the list is: {average}");
                Console.WriteLine($"The largest number of this list is {largest}");
            

        
    }
}