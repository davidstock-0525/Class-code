using System.Runtime.CompilerServices;

class Reflection
{
    private string _prompt1;
    private string _prompt2;
    private List<string> _prompts1list = new List<string>
    {"Think of a time when you stood up for someone else","Think of a time when you did something really difficult",
    "Think of a time when you helped someone in need","Think of a time when you did something truly selfless"};
    private List<string> _propts2list = new List<string>
    {"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?",
    "How did you feel when it was complete?","What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};

    public Reflection()
    {
        Random random = new Random();
        int randomnumber = random.Next(_prompts1list.Count);
        _prompt1 = _prompts1list[randomnumber];
        Random random2 = new Random();
        int randomnumber2 = random2.Next(_propts2list.Count);
        _prompt2 = _propts2list[randomnumber2];
    }
}