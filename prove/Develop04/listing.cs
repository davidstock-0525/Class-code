using System.Formats.Asn1;

class Listing: Baseactivity
{
    private List<string> _thinkAboutIt = new List<string>
    {"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
    private int _completions;

    private string _prompt;

    public Listing(string name, string description):
    base(name, description)
    {
        Random random = new Random();
        int number = random.Next(_thinkAboutIt.Count);
        _prompt = _thinkAboutIt[number];
        _completions = 0;
    }

    public void runListing()
    {
        WelcomeMessage();
        setDuration();
        Console.WriteLine(_prompt);
        StartActivity();
        while(timerHasExpried() == false)
        {
            string Answer = Console.ReadLine();
            _completions += 1;
        }
        displayendmessage();
        Console.WriteLine($"You completed {_completions} number of entries");
    }
}