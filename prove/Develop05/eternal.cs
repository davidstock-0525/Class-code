using System.Diagnostics.Contracts;

class Eternal:Basegoal
{
    private int _repPoints;

    public Eternal()
    :base()
    {
        Console.WriteLine("How many points per rep? ");
        _repPoints = int.Parse(Console.ReadLine());
    }

    public Eternal(string name, string description, int points, bool status, string Goaltype, string focus, int goalnumber, int _repPoints)
    :base(name, description, points, status, Goaltype, focus, goalnumber)
    {
        
    }
    public override int RecordEvent()
    {
        return _repPoints;
    }

    public override string SavetoFileString()
    {
        return $"{_name}#{_description}#{_pointValue}#{_isComplete}#{_type}#{_focus}#{_goalNumber}#{_repPoints}";
    }
}