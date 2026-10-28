class Doctor : Person
{
    private string _tools;

    public Doctor(string firstName, string LastName, int age, double weight, string tools)
    : base (firstName, LastName, age, weight)
    {
        _tools = tools;
    }

    public string getdoctorinfo()
    {
        string info = ($"{_tools},{getinfo()}");
        return info;
    }
}