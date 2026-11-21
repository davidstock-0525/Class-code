class Checklist:Basegoal
{
    private int _repetions;
    private int _repetionComplete;
    private int _repetionPoints;
    public Checklist()
    :base()
    {
        _focus = "Checklist";
        Console.WriteLine("How many times should this goal repeat");
        _repetions = int.Parse(Console.ReadLine());
        Console.WriteLine("How many point per rep? ");
        _repetionPoints = int.Parse(Console.ReadLine());
        
    }

    public Checklist(string name, string description, int points, bool status, string Goaltype, string focus, int goalnumber, int repetions, int repscomlete, int repetionPoints)
    :base(name, description, points, status, Goaltype, focus, goalnumber)
    {
        _repetions = repetions;
        _repetionComplete = repscomlete;
        _repetionPoints = repetionPoints;
    }

    public override string SavetoFileString()
    {
        return$"{_name}#{_description}#{_pointValue}#{_isComplete}#{_type}#{_focus}#{_goalNumber}#{_repetions}#{_repetionComplete}#{_repetionPoints}";
    }

   
    
    public override int RecordEvent()
    {
        _repetionComplete += 1;
        if (_repetionComplete == _repetions)
        {
            return Markcomplete() + _repetionPoints;
        }
        else
        {
            return _repetionPoints;
        }
    }

    public override string GetConsoleOutput()
    {
       string completeString = " ";
       if(_isComplete)
            completeString = "X";
        return $"{_goalNumber}. [{completeString}] - {_type}, Goal name: {_name}, Description: {_description}, type: {_type} Points: {_pointValue}, Points once done: {_repetionPoints} [{_repetionComplete}/{_repetions}]";
    }
}