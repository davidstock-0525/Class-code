using System.Diagnostics.Contracts;

class Circle
{
    public double _radius;


    public double GetArea()
    {
        return _radius * _radius * 3.14159;
    }
}