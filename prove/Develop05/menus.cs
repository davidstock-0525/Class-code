using System.Diagnostics;

class Menu
{
    private string _choice;

    public Menu()
    {
    }
    public void MenuOne()
    {
        Console.WriteLine("What would you like to do? ");
        Console.WriteLine("1. Create goal");
        Console.WriteLine("2. Record event");
        Console.WriteLine("3. Save goals");
        Console.WriteLine("4. Load goals");
        _choice = Console.ReadLine();

        switch (_choice)
        {
            case "1":
                MenuTwo();
                break;
        }

    }

    public void MenuTwo()
    {
        Console.WriteLine("What kind of goal would you like to make? ");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Checklist ");
        Console.WriteLine("3. eternal ");
        _choice = Console.ReadLine();

        switch (_choice)
        {
            case "1":
                Simplegoal tempsimp = new Simplegoal();

                break;
        }
    }

     
}