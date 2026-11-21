using System.Diagnostics.Contracts;

class Eternal:Basegoal
{

    public Eternal()
    :base()
    {
        _focus = "Eternal";
    }

    public Eternal(string name, string description, int points, bool status, string Goaltype, string focus, int goalnumber)
    :base(name, description, points, status, Goaltype, focus, goalnumber)
    {
    }
    public override int RecordEvent()
    {
        return _pointValue;
    }

    public override string SavetoFileString()
    {
        return $"{_name}#{_description}#{_pointValue}#{_isComplete}#{_type}#{_focus}#{_goalNumber}";
    }
}