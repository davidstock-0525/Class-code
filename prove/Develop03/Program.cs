using System;
using Develop03;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("bubba");
        myWord.printword();
        myWord.hide();
        myWord.printblanks();

        Scripture myScripture = new Scripture("moses", 1, 39, "Behold, this is my work and my glory");
        myScripture.showScripture();
    }
}