class Simplegoal: Basegoal
{
    public Simplegoal()
    :base()
    {
        
    }

    public Simplegoal(string name, string description, int points, bool status, string Goaltype, string focus, int goalnumber)
    :base(name, description, points, status, Goaltype, focus, goalnumber)
    {
        
    }

    public override int RecordEvent()
    {
        return 0;
    }
}