class Checklist:Basegoal
{
    private int _repetions;
    private int _repetionComplete;
    private int _repetionPoints;
    public Checklist()
    :base()
    {
        Console.WriteLine("How many times should this goal repeat");
        _repetions = int.Parse(Console.ReadLine());
        Console.WriteLine("How many point per rep? ");
        _repetionPoints = int.Parse(Console.ReadLine());
        
    }

   
    
    public override int RecordEvent()
    {
        _repetionComplete += 1;
        if (_repetionComplete != _repetions)
        {
            return Markcomplete() + _repetionPoints;
        }
        else
        {
            return _repetionPoints;
        }
    }
}