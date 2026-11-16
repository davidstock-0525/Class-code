class Sqaure:Shape
{
   private int _side;

   public Sqaure(string color, int side)
   :base(color)
    {
        _side = side;
    }

    public override double getarea()
    {
        return _side*_side;
    }
}