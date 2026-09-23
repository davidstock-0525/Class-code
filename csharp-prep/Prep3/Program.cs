using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a number ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        Console.Write("Please enter your guess ");
        string guessinput = Console.ReadLine();
        int guess = int.Parse(guessinput);

        if (number > guess)
            Console.WriteLine("Higher");
        else if (number < guess)
            Console.WriteLine("Lower");
        else 
            Console.WriteLine("Correct");
    }
}