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
        string choice = "0";
        while (choice == "0")
        {
            
            List<string> prompts = new List<string>()
            {
                "How was your day?",
                "What was your favortie quoute?",
                "What made you angry?",
                "What did you learn?",
                "What are you looking forward too?"
            };

            List<string> future = new List<string>()
            {
            "Where are you?",
            "What have you achomplished?",
            "What drives you foward?",
            "Who are you with?",
            "Who are you?" 
            };

            Random random = new Random();
            int index = random.Next(prompts.Count);

            Random futurerandom = new Random();
            int futureindex = random.Next(future.Count);
    ;
            Console.WriteLine("Are you making a present or future entry?");
            Console.WriteLine("1 for now, 2 for future");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string input = prompts[index];
                _date = DateTime.Now.ToString();
                _prompt = input;
                Console.Write(_prompt);
                _response = Console.ReadLine();
            }
            else if (choice == "2")
            {
                string futureinput = future[futureindex];
                _date = DateTime.Now.ToString();
                _prompt = futureinput;
                Console.Write(_prompt);
                _response = Console.ReadLine();
            }
            else
            {
                choice = "0";
            }
        }
    }

    public string ToFileString()
    {
        return $"{_date}#{_prompt}#{_response}";
    }
}