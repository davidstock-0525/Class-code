class Police: Person
{
    private string _weapons;

    public Police(string firstName, string LastName, int age, double weight, string weapons)
    : base (firstName, LastName, age, weight)
    {
        _weapons = weapons;
    }

    public string getpoliceinfo()
    {
        string info = ($"{_weapons},{getinfo()}");
        return info;
    }
}