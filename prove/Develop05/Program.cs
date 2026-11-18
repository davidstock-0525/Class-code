using System;

class Program
{
    static void Main(string[] args)
    {
        Simplegoal mySimple = new Simplegoal();
        Console.WriteLine(mySimple.GetConsoleOutput());
        mySimple.Markcomplete();
        Console.WriteLine(mySimple.GetConsoleOutput());
    }
}