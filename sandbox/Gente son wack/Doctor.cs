class Doctor : Person
{
    private string _tools;

    public Doctor(string firstName, string LastName, int age, double weight, string tools)
    : base (firstName, LastName, age, weight)
    {
        _tools = tools;
    }

    public override string getinfo()
    {
        string info = ($"{_tools},{base.getinfo()}");
        return info;
    }
}