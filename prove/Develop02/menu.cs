using System;
using System.Diagnostics.CodeAnalysis;

namespace Develop02.obj;
class Menu
{
    public int ProcessMenu()
    {
        int response = 0;

        while (response < 1 || response > 5)
        {
            Console.WriteLine("Welcome to the journal Program");
            Console.WriteLine("Create, display, Save, Read Journal entry");
            Console.WriteLine("1. Create new Journal entry");
            Console.WriteLine("2. Display Journal entry");
            Console.WriteLine("3. Save to file");
            Console.WriteLine("4. Read from file");
            Console.WriteLine("5. Quit");
            Console.Write(">");
            
            response = int.Parse(Console.ReadLine());
        }

        return response;
        
    }
}
