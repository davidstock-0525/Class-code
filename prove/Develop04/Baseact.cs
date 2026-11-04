class Baseactivity
{
    private string _name;
    private int _duration;
    
    public Baseactivity(string name)
    {
        _name = name;
    }

    public void RunCountDownMessage(string message)
    {
        Console.CursorVisible = false;
        for(int i=_duration; i>=1; i--)
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

    public void setDuration()
    {
        Console.WriteLine("How long should this last?");
        _duration = int.Parse(Console.ReadLine());
    }

    public void WelcomeMessage()
    {
        Console.WriteLine($"Welcome to {_name} activity");
    }
}