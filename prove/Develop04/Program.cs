using System;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {
        Baseactivity activity = new Baseactivity("Based");
        activity.RunCountDownMessage("hello");
        activity.displayspinnermessage("Well done", 10);
    }
}