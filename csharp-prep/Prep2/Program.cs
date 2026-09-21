using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a precentage: ");
        string input = Console.ReadLine();
        int percentagae = int.Parse(input);

        if (percentagae >= 90)
        {
            Console.WriteLine("A");
        }
        else if (percentagae >= 80)
        {
            Console.WriteLine("B");
        }
        else if (percentagae >= 70)
        {
            Console.WriteLine("C");
        }
        else if (percentagae >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
        if (percentagae >= 70)
        {
            Console.WriteLine("You've passed");
        }
        else
        {
            Console.WriteLine("You've failed");
        }
    }
}