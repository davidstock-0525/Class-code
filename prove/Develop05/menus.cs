using System.Collections;
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
                        if (item.CheckComplete() == false)
                        {
                            _totalpoints += item.RecordEvent();
                        }
                        else
                        {
                            Console.WriteLine("This goal has been completed");
                        }
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
                        if(parts[5] == "simple")
                        {
                            Simplegoal tempsimp = new Simplegoal(parts[0],parts[1],int.Parse(parts[2]),bool.Parse(parts[3]),parts[4],parts[5],int.Parse(parts[6]));
                            _goallist.AddGoal(tempsimp);
                        }
                        else if (parts[5] == "Checklist")
                        {
                            Checklist tempcheck = new Checklist(parts[0],parts[1],int.Parse(parts[2]),bool.Parse(parts[3]),parts[4],parts[5],int.Parse(parts[6]),int.Parse(parts[7]),int.Parse(parts[8]),int.Parse(parts[9]));
                            _goallist.AddGoal(tempcheck);
                        }
                        else if (parts[5] == "Eternal")
                        {
                            Eternal tempEnter = new Eternal(parts[0],parts[1],int.Parse(parts[2]),bool.Parse(parts[3]),parts[4],parts[5],int.Parse(parts[6]));
                            _goallist.AddGoal(tempEnter);
                            
                        }
                    }
                }
                Console.WriteLine("Which goal would you like to record? ");
                foreach (Basegoal item in _goallist.Getlist())
                {
                   _iteration += 1; 
                   item.SetGoalNumber(_iteration);
                   Console.WriteLine(item.GetConsoleOutput());
                }
            break;

            default:
                Console.WriteLine("Invaild input, please enter 1-4");
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
            
            case "2":
                Checklist tempcheck = new Checklist();
                _goallist.AddGoal(tempcheck);
                break;
            
            case "3":
                Eternal tempEter = new Eternal();
                _goallist.AddGoal(tempEter);
                break;

            default:
                Console.WriteLine("Invaild input. please enter 1-3");
                break;
        }
    }   
}