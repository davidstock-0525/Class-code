using System.Diagnostics;

class Menu
{
    private string _choice;
    private Goals _goallist = new Goals();
    private int _iteration;

    public Menu()
    {
    }
    public void MenuOne()
    {
        _iteration = 0;
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

            case "2":
                Console.WriteLine("Which goal would you like to record? ");
                foreach (Basegoal item in _goallist.Getlist())
                {
                   _iteration += 1; 
                   item.SetGoalNumber(_iteration);
                   Console.WriteLine(item.GetConsoleOutput());
                }
                Console.ReadLine();
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
                _goallist.AddGoal(tempsimp);
                break;
        }
    }

    public void Menuthree()
    {
        Console.WriteLine("What type of goal is this? ");
        Console.WriteLine("1. Phyical");
        Console.WriteLine("2. spritual ");
        Console.WriteLine("3. social ");
        Console.WriteLine("4. intellectual ");
        _choice = Console.ReadLine();
        switch("choice")
        {
            case "1":
            

        }
    }

     
}