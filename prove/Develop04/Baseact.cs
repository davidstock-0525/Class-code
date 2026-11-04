class Baseactivity
{
    string _name;
    string _welcomeMessage;
    int _duration;
    string _endmessage;
    public Baseactivity(string name, string welcomeMessage, int duration, string endMessage)
    {
        _name = name;
        _welcomeMessage = welcomeMessage;
        _duration = duration;
        _endmessage = endMessage;
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for(int i=seconds; i>=1; i--)
        {
            Console.Clear();
            Console.Write($"{i} - {message}");
            Thread.Sleep(1000);
        } 
        Console.CursorVisible = true;
    }

    public void displayspinnermessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        Console.Clear();
        Console.Write($"{message} ");
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("+");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
        }
        Console.CursorVisible = true;
    }

    public void setTimer(int timer)
    {
        _duration = timer;
    }
}