using System;

namespace Learning02;

public class Job
{
    public string _company = "";
    public string _jobtitle = "";
    public string _startyear = "";
    public string _endyear = "";

    public void displaycarrer()
    {
        Console.WriteLine($"{_jobtitle} ({_company}) {_startyear}-{_endyear}");
    }
}
