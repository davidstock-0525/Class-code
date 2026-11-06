using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Net.Security;

class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Which activity would you like? ");
        Console.WriteLine("1. Breathing activity");
        Console.WriteLine("2. Reflection activity");
        string selection = Console.ReadLine();
        switch(selection)
        {
            case "1":
            Breathing newBreathing = new Breathing("breathing","An you will center yourself through breath control");
            newBreathing.runactivity();
            break;

            case "2":
            Reflection newReflection = new Reflection();
            newReflection.runreflection();
            break;
        }  
    }
}