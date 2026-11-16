using System.Diagnostics.Contracts;

class Basegoal
{
    private int _pointValue;
    private string _output;
    private bool _isComplete;
    private int _goalNumber;
    private string _name;
    private string _description;
    private string _type;
    public Basegoal()
    {
        SetGoalName();
        SetDescription();
        SetPoints();
    }

    private void SetGoalName()
    {
        Console.WriteLine("Please enter the name of your goal ");
        _name = Console.ReadLine();
    }

    public string GetConsoleOutput()
    {
        return $"Goal name: {_name}";
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
}