using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // bool done = false;

        // while (! done)
        // {
        //     Console.Write("Are we done? (y/n) ");
        //     done = Console.ReadLine() == "y";
        // }

        // bool done;

        // do
        // {
        //     Console.Write("Are we done? (y/n) ");
        //     done = Console.ReadLine() == "y"; 
        // } while (! done);

        // for(int i = 100000; i > -1; i -= 10000)
        // {
        //     Console.WriteLine(i);
        // }

        // List<string> myFriends = new List<string> {"Bob", "Betty", "Bubba"};
        // myFriends.Add("James");
        // myFriends.Add("Doug");

        // foreach(string name in myFriends)
        // {
        //     Console.Write($"{name} ");
        // }

        static double AddNumbers(double x, int y)
        {
            return x + y;
        }
        Console.Write(AddNumbers(4.5, 5));
    }
}