class Person
{
    private string _fristName;
    private string _lastName;
    private int _age;
    private double _weight;

    public Person(string firstName, string lastName, int age, double weight)
    {
        _fristName = firstName;
        _lastName = lastName;
        _age = age;
        _weight = weight;
    }

    public string getinfo()
    {
        string info = ($"{_fristName} {_lastName} weighs {_weight} and is {_age} years old");
        return info;
    }
}