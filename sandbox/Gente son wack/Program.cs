class Program
{
    static void Displaypersoninformation(Person person)
    {
        // if(person is Doctor d)
        // {
        //     Console.WriteLine(d.getinfo());
        // }
        // else if(person is Police p)
        // {
        //     Console.WriteLine(p.getinfo());
        // }
        // else
        // {
            Console.WriteLine(person.getinfo());
        //}

    }
    static void Main()
    {
        Person myPerson = new Person("Ryan", "stiller", 32, 210);
        //Console.WriteLine(myPerson.getinfo());

        Police myPolice = new Police("Lance", "Bob", 34, 186, "taser");

        //Console.WriteLine(myPolice.getpoliceinfo());

        Doctor myDoctor = new Doctor("billy", "pain", 20, 150, "knife");

        //Console.WriteLine(myDoctor.getdoctorinfo());

        List<Person> myPeople = new List<Person>();

        myPeople.Add(myDoctor);
        myPeople.Add(myPolice);
        myPeople.Add(myPerson);

        foreach (Person person in myPeople)
        {
            Displaypersoninformation(person);
            //Console.WriteLine(person.getinfo());
            //if(person is Doctor)
            //{
                //myDoctor.getdoctorinfo();
            //}
        }
    }
}
