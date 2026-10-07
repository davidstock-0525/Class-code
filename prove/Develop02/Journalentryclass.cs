public class JournalEntry
{
    public string _date;

    public string _prompt;

    public string _response;

    public void DisplayEntry()
    {
        Console.Write($"{_date}, ");
        Console.Write($"{_prompt}, ");
        Console.WriteLine($"{_response}, ");
    }

    public void CreateJournalEntry()
    {
        DateTime Date = DateTime.Now;
        _date = Date.ToString();
        _prompt = "How was your day? ";

        Console.Write($"{_prompt}");

        _response = Console.ReadLine();

    }

    
}