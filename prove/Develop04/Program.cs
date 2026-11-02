using System;

class Program
{
    static void Main(string[] args)
    {
        Baseactivity activity = new Baseactivity();
        activity.RunCountDownMessage("hello", 5);
        activity.displayspinnermessage("Well done", 5);
    }
}