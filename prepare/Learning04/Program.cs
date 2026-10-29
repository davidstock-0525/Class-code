using System;

class Program
{
    static void Main(string[] args)
    {
        Math myMath = new Math("6.45", "1-709", "tony ridenjur", "decimals");
        Console.WriteLine(myMath.getsummary());
        Console.WriteLine(myMath.GetHomeworkList());

        Writing  myWriting = new Writing("The history of fnaf, and it's effect on the iraq war", "Bob fuller", "politics");
        Console.WriteLine(myWriting.getsummary());
        Console.WriteLine(myWriting.getWritinginformation());
    }
}