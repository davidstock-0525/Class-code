class Breathing: Baseactivity
{
    public Breathing(string name, string description)
    : base(name, description)
    {}

    public void runactivity()
    {
        WelcomeMessage();
        setDuration();
        RunCountDownMessage("Get ready", 5);
        StartActivity();
        while (timerHasExpried() == false)
        {
            displayspinnermessage("Breath in ...", 4);
            displayspinnermessage("hold breath... ", 4);
            displayspinnermessage("breath out...", 4);
            displayspinnermessage("hold...", 4);
        }
        displayendmessage();
    }
}