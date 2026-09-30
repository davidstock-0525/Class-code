using System;
using System.ComponentModel;
using Learning02;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobtitle = "janitor";
        job1._company = "Mircosoft";
        job1._startyear = "1945";
        job1._endyear = "2025";

        Job job2 = new Job();
        job2._jobtitle = "astronuaght";
        job2._company = "Time sailors";
        job2._startyear = "3045";
        job2._endyear = "4056";

        Job job3 = new Job();
        job3._jobtitle = "tony";
        job3._company = "ryan";
        job3._startyear = "1609";
        job3._endyear = "1704";

        Resume resume1 = new Resume();
        resume1._name = "pedro pascale";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._jobs.Add(job3);
        resume1.displayresume();
    }
}

