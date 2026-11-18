using System.Diagnostics.Contracts;

abstract class Basegoal
{
    private int _pointValue;
    private bool _isComplete;
    private int _goalNumber;
    private string _name;
    private string _description;
    private string _type;
    private string _focus;
    public Basegoal()
    {
        SetGoalName();
        SetDescription();
        SetPoints();
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

    public void SavetoFileString()
    {
        
    }
    
}