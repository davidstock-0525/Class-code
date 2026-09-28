using System;
using System.Diagnostics;

class Program
{
    static void Displaywelcome()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string Promptuserage()
    {
        Console.Write("What is your age? ");
        string age = Console.ReadLine();
        return age;
    }
    static int Promptusernumber()
    {
        Console.Write("what is your favorite number? ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
    }
}