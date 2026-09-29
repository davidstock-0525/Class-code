using System;

namespace Learning02;

public class Resume
{
    public string _name = "";
    public List <Job> _jobs = new List<Job>();
    public void displayresume()
    {
        Console.WriteLine(_name);
        foreach (Job job in _jobs)
            job.displaycarrer();
    }
}
