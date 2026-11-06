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
        Console.Write("3. Listing activity");
        string selection = Console.ReadLine();
        switch(selection)
        {
            case "1":
            Breathing newBreathing = new Breathing("breathing","An you will center yourself through breath control");
            newBreathing.runactivity();
            break;

            case "2":
            Reflection newReflection = new Reflection("Reflection","Spend some time thinking of an imporant moment in your life");
            newReflection.runreflection();
            break;

            case "3":
            Listing newListing = new Listing("Listing", "This activity will allow you to list good things about yourself and your life");
            newListing.runListing();
            break;
        }  
    }
}