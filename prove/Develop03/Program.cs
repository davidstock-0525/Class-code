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
    }
}