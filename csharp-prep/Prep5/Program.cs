using System;
using System.Diagnostics;

class Program
{
    static void Displaywelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string Promptusername()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
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

    static void promptuserbrith(out int brithyear)
    {
        Console.Write("What is your birthyear? ");
        string input = Console.ReadLine();
        brithyear = int.Parse(input);
    }

    static int squarenumber(int number)
    {
        int squared = number*number;
        return squared;
    }

    static void Displayanswers(int birthyear, string name, int squared)
    {
        Console.WriteLine($"{name}, Your squared number is {squared}");
        Console.WriteLine($"{name}, you will turn {2026-birthyear} this year");
    }
    static void Main(string[] args)
    {
        Displaywelcome();
        string name = Promptusername();
        Promptuserage();
        int usernumber = Promptusernumber();
        int year;
        promptuserbrith(out year);
        int squared = squarenumber(usernumber);
        Displayanswers(year, name, squared);
    }
}