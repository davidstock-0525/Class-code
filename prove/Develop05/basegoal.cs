using System.Diagnostics.Contracts;
using System.Xml.Serialization;

abstract class Basegoal
{
    protected int _pointValue;
    protected bool _isComplete;
    protected int _goalNumber;
    protected string _name;
    protected string _description;
    protected string _type;
    protected string _focus;
    public Basegoal()
    {
        SetGoalName();
        SetDescription();
        SetPoints();
        SetGoalType();
        _isComplete = false;
    }

    public Basegoal(string name, string description, int points, bool complete, string Goaltype, string focus, int goalnumber)
    {
        _name = name;
        _description = description;
        _pointValue = points;
        _isComplete = complete;
        _type = Goaltype;
        _focus = focus;
        _goalNumber = goalnumber;
    }

    private void SetGoalName()
    {
        Console.WriteLine("Please enter the name of your goal ");
        _name = Console.ReadLine();
    }

    public virtual string GetConsoleOutput()
    {
       string completeString = " ";
       if(_isComplete)
            completeString = "X";
        return $"{_goalNumber}. [{completeString}] - {_type}, Goal name: {_name}, Description: {_description}, Points: {_pointValue}";
    }

    private void SetDescription()
    {
        Console.WriteLine("PLease describe your goal ");
        _description = Console.ReadLine();
    }

    private void SetPoints()
    {
        Console.WriteLine("How many points is it worth? ");
        _pointValue = int.Parse(Console.ReadLine());
    }

    public int Markcomplete()
    {
        _isComplete = true;
        return _pointValue;
    }

    public abstract int RecordEvent();

    public virtual string SavetoFileString()
    {
        return($"{_name}#{_description}#{_pointValue}#{_isComplete}#{_type}#{_focus}#{_goalNumber}");
    }

    public void SetGoalNumber(int goalnumber)
    {
        _goalNumber = goalnumber;
    }

    public int GetGoalNumber()
    {
        return _goalNumber;
    }

    public void SetGoalType()
    {
        string choice = "0";
        Console.WriteLine("What type of goal is this? ");
        Console.WriteLine("1. Phyical");
        Console.WriteLine("2. spritual ");
        Console.WriteLine("3. social ");
        Console.WriteLine("4. intellectual ");
         Console.ReadLine();
        switch(choice)
        {
            case "1":
                _type = "Physical";
                break;
            
            case "2":
                _type = "spritual";
                break;
            
            case "3":
                _type = "social";
                break;

            case "4":
                _type = "intellectual";
                break;
            

        }
    }

    
}