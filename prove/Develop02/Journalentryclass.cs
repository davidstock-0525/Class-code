public class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}, {_response}");
    }

    public void CreateJournalEntry()
    {
        List<string> prompts = new List<string>()
        {
            "How was your day?",
            "What was your favortie quoute?",
            "What made you angry?",
            "What did you learn?",
            "What are you looking forward too?"
        };

         Random random = new Random();
        int index = random.Next(prompts.Count);
;
        string input = prompts[index];
        _date = DateTime.Now.ToString();
        _prompt = input;
        Console.Write(_prompt);
        _response = Console.ReadLine();
    }

    public string ToFileString()
    {
        return $"{_date}#{_prompt}#{_response}";
    }
}