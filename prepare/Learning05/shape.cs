using System.Diagnostics.Contracts;

class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public void setColor()
    {
       Console.Write("What color would you like? ");
        _color = Console.ReadLine();
    }

    public string getcolor()
    {
        return _color;
    }

    public virtual double getarea()
    {
        return 0.9;
    }
}