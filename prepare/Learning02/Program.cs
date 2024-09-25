using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2030;

        Job job2 = new Job();

        job2._jobTitle = "Employee";
        job2._company = "Facebook";
        job2._startYear = 2000;
        job2._endYear = 2010;

        Resume resume = new Resume();
        resume._name = "Michael Afton";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResumeDetails();
    }
    
}