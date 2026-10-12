using System.Security.Cryptography;
using Microsoft.VisualBasic;

class Program 
{
  
  static void Main()
  {
    Console.WriteLine("hello circle");

    Circle myCircle = new Circle();
    myCircle.SetRadius(10);

    double area = myCircle.GetArea();
  }
}
