class Baseactivity
{
    private string _name;
    private int _duration;
    private string _description;

    private DateTime _endTime;
    
    public Baseactivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public void RunCountDownMessage(string message, int duration)
    {
        Console.CursorVisible = false;
        for(int i=duration; i>=1; i--)
        {
            Console.Clear();
            Console.Write($"{i} - {message}");
            Thread.Sleep(1000);
        } 
        Console.CursorVisible = true;
    }

    public void displayspinnermessage(string message, int duration)
    {
        Console.CursorVisible = false;
        Console.Clear();
        Console.Write($"{message}");
        DateTime localendTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < localendTime)
        {
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("/");

        }
        Console.CursorVisible = true;
    }

    public void setDuration()
    {
        Console.Write("How many seconds should activity this last?");
        _duration = int.Parse(Console.ReadLine());
    }

    public int getDuration()
    {
        return _duration;
    }

    public bool timerHasExpried()
    {
        if (DateTime.Now > _endTime)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void WelcomeMessage()
    {
        Console.WriteLine($"Welcome to {_name} activity");
        Console.WriteLine(_description);
    }

    public void displayendmessage()
    {
        Console.Clear();
        Console.WriteLine($"Congrats, you completed {_duration} seconds of {_name} activity");
    }
}