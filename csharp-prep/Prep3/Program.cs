using System;
using System.Reflection.Metadata;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        bool correct = false;
        bool playAgain = false;
        
        
        
        
        while (! playAgain)
        {
        correct = false;
        int number = Random.Shared.Next(1, 101);
        int attempts = 0;
            while (! correct)
            {
        
                Console.Write("Please enter your guess ");
                string guessinput = Console.ReadLine();
                int guess = int.Parse(guessinput);

                if (number > guess)
                {
                    Console.WriteLine("Higher");
                    attempts += 1;
                }
                else if (number < guess)
                {
                    Console.WriteLine("Lower");
                    attempts += 1;
                }
                else 
                {
                    Console.WriteLine($"Correct, You took {attempts} attempts");
                    correct = true;
                }
            }
            Console.Write("Would you like to play again? (y/n) ");
            string again = Console.ReadLine();
            if (again != "y")
                playAgain = true;
        }
    }
}