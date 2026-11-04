using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Net.Security;

class Program
{
    
    static void Main(string[] args)
    {
        string selection = "1";
        Console.WriteLine("Which activity would you like? ");
        Console.Write("1. Breathing activity");
        Console.ReadLine();
        switch(selection)
        {
            case "1":
            Breathing newBreathing = new Breathing("breathing","An you will center yourself through breath control");
            newBreathing.runactivity();;
            break;
        }  
    }
}