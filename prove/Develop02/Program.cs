using System;
using Develop02.obj;

class Program
{
    static void Main(string[] args)
    {
       Menu myMenu = new Menu();

       int response = 0;

       JournalEntry Newentry = new JournalEntry();
       Journal Journal = new Journal();

       while (response != 5)
        {
            response = myMenu.ProcessMenu();
            switch (response)
            {
                case 1:
                    Console.WriteLine("create");
                    Journal.SaveToJournal();
                    break;
                case 2:
                    Console.WriteLine("Display");
                    Newentry.DisplayEntry();
                    break;
                case 3:
                    Console.WriteLine("Save");
                    Console.Write("What is the file name? ");
                    String filename = Console.ReadLine();
                    Journal.WriteToFile(filename);
                    break;
                case 4:
                    Console.WriteLine("Read");
                    Console.WriteLine("What is the name of the file in you system? ");
                    string input = Console.ReadLine();
                    Journal.ReadFromFile(input);
                    break;
            }
        }
    }
}
