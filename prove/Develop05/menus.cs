using System.Diagnostics;

class Menu
{
    private string _choice;
    private Goals _goallist = new Goals();
    private int _iteration;
    private int _totalpoints;

    public Menu()
    {
    }
    public void MenuOne()
    {
        _iteration = 0;
        Console.WriteLine($"You have {_totalpoints}");
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
                int index = 0;
                index = int.Parse(Console.ReadLine());
                foreach (Basegoal item in _goallist.Getlist())
                {
                    if(index == item.GetGoalNumber())
                    {
                        _totalpoints += item.RecordEvent();
                    }
                }
                break;

            case "3":
            using (StreamWriter outputFile = new StreamWriter("goals.txt"))
            {
                outputFile.WriteLine(_totalpoints);
                foreach (Basegoal item in _goallist.Getlist())
                {
                    outputFile.WriteLine(item.SavetoFileString());
                }
            }
            break;

            case "4":
            using (StreamReader inputfile = new StreamReader("goals.txt"))
                {
                    _totalpoints = int.Parse(inputfile.ReadLine());
                    string line; 
                    
                    while ((line = inputfile.ReadLine()) != null)
                    {
                        string[] parts = line.Split('#');
                        if(parts[6] == "simple")
                        {
                            Simplegoal tempsimp = new Simplegoal(parts[0],parts[1],int.Parse(parts[2]),bool.Parse(parts[3]),parts[4],parts[5],int.Parse(parts[6]));
                            _goallist.AddGoal(tempsimp);
                        }
                    }
                }
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