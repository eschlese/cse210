using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Arcteryx";
        job1._jobTitle = "Web Developer";
        job1._startYear = "2008";
        job1._endYear = "2012";

        Job job2 = new Job();
        job2._company = "Bioware";
        job2._jobTitle = "Software Developer";
        job2._startYear = "2012";
        job2._endYear = "2013";

        Resume resume = new Resume();
        resume._name = "Mike Wazowski";
        resume._jobs.AddRange([job1, job2]);

        resume.Display();
    }
}