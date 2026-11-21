class Eternal:Basegoal
{
    private int _repPoints;

    public Eternal()
    :base()
    {
        Console.WriteLine("How many points per rep? ");
        _repPoints = int.Parse(Console.ReadLine());
    }
    public override int RecordEvent()
    {
        return _repPoints;
    }
}