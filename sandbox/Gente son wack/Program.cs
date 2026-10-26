class Program
{
    static void Main()
    {
        Person myPerson = new Person("Ryan", "stiller", 32, 210);
        myPerson.Displayinfo();

        Police myPolice = new Police("Lance", "Bob", 34, 186, "taser");

        myPolice.Displayinfo();
    }
}
