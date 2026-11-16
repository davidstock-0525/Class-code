class Circle:Shape
{
    private int _radius;

    public Circle(string color, int radius)
    :base(color)
    {
        _radius = radius;
    }

    public override double getarea()
    {
        return _radius*_radius*Math.PI;
    }
}