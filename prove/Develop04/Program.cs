using System;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {
        Baseactivity activity = new Baseactivity("Based", "hello", 5, "die");
        activity.RunCountDownMessage("hello", 5);
        activity.displayspinnermessage("Well done", 10);
    }
}