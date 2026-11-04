class Breathing: Baseactivity
{
    public Breathing(string name)
    : base(name)
    {}

    public void runactivity()
    {
        WelcomeMessage();
        setDuration();
        RunCountDownMessage("Breath in");
    }
}