class Baseactivity
{
    public Baseactivity()
    {
        //make constructer
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
}