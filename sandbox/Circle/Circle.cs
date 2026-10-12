using System.Diagnostics.Contracts;
using System.IO.Compression;

class Circle
{
    private double _radius;

    public Circle()
    {
        _radius = 1.0;
    }

    public Circle(double radius)
    {
        _radius = radius;
        SetRadius(radius);
    }


    public double GetArea()
    {
        return _radius * _radius * 3.14159;
    }

    public double GetCircumference()
    {
        return 2 * 3.14 * _radius;
    }

    public void SetRadius(double radius)
    {
        if (radius < 0.0 )
        {
            _radius = 1.0;
            Console.WriteLine("Error, Radius must have positive value");
        }
        else
        {
            _radius = radius;
        }
    }
}