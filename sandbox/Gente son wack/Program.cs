class Program
{
    static void Main()
    {
        Person myPerson = new Person("Ryan", "stiller", 32, 210);
        Console.WriteLine(myPerson.getinfo());

        Police myPolice = new Police("Lance", "Bob", 34, 186, "taser");

        Console.WriteLine(myPolice.getpoliceinfo());
    }
}
