using System.Diagnostics;

class Menu
{
    private string _choice;

    public Menu()
    {
    }
    public void MenuOne()
    {
        Console.WriteLine("What would you like to do? ");
        Console.WriteLine("1. Create goal");
        Console.WriteLine("2. Record event");
        Console.WriteLine("3. Save goals");
        Console.WriteLine("4. Load goals");
        _choice = Console.ReadLine();

        Switch _choice;

            Case "1";
            break;
    }

     
}