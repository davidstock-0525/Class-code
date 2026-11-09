class Police: Person
{
    private string _weapons;

    public Police(string firstName, string LastName, int age, double weight, string weapons)
    : base (firstName, LastName, age, weight)
    {
        _weapons = weapons;
    }

    public override string getinfo()
    {
        string info = ($"{_weapons},{base.getinfo()}");
        return info;
    }

    public override double getsalary()
    {
        return 35000.00;
    }
}