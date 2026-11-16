using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Sqaure mysquare = new Sqaure("blue", 5);

        Circle mycircle = new Circle("red", 4);
        
        Rectangle myrectangle = new Rectangle("yellow", 4, 5);

        List<Shape> shapelist = new List<Shape>();

        shapelist.Add(mycircle);
        shapelist.Add(myrectangle);
        shapelist.Add(mysquare);

        foreach (Shape shape in shapelist)
        {
            Console.WriteLine(shape.getarea());
        }

        


    }


    
    
}