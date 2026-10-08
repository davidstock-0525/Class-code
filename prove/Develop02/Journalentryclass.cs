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
        _date = DateTime.Now.ToString();
        _prompt = "How was your day? ";
        Console.Write(_prompt);
        _response = Console.ReadLine();
    }

    public string ToFileString()
    {
        return $"{_date}#{_prompt}#{_response}";
    }
}