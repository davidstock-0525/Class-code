using System;
using System.ComponentModel.Design;
using Develop03;

class Program
{
    static void Main(string[] args)
    {
        string quit = "z";
        Scripture Book_of_mormon = new Scripture("Ether", 12, 27, "And if men come unto me I will show unto them their weakness."+
        "I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me;"+
        "for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");
        
        Scripture New_testament = new Scripture("Luke", 2, 9, 10, "And, lo, the angel of the Lord came upon them, and the glory of"+
        "the Lord shone round about them: and they were sore afraid."+
        "And the angel said unto them, Fear not: for, behold, I bring you good tidings of great joy, which shall be to all people.");

        Scripture Old_testament = new Scripture("Isaiah", 1, 18, "Come now, and let us reason together, saith the Lord: though"+
        "your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool.");

        Scripture DandC = new Scripture("D&C", 9, 8, 9, "But, behold, I say unto you, that you must study it out in your mind;"+
        "then you must ask me if it be right, and if it is right I will cause that your bosom shall burn within you; therefore,"+
        "you shall feel that it is right.");
        
        Console.WriteLine("Welcome to Scripture memorizer. Press enter to hide words, press Q to quit");
        Console.WriteLine("Please pick book:");
        Console.WriteLine("1. Book of mormon");
        Console.WriteLine("2. New testament");
        Console.WriteLine("3. Old testament");
        Console.WriteLine("4. D&C");
        string Selection = "1";
        Selection = Console.ReadLine();
        Scripture myScripture = Book_of_mormon;

        switch(Selection)
        {
            case "1":
                myScripture = Book_of_mormon;
                break;
            
            case "2":
                myScripture = New_testament;
                break;

            case "3":
                myScripture = Old_testament;
                break;

            case "4":
                myScripture = DandC;
                break;
        }

        while (quit != "q")
        {
            Console.Clear();
            Reference myRef = new Reference(myScripture);
            myRef.printRef();
            myScripture.showScripture();
            quit = Console.ReadLine();
        }
            
    }
}