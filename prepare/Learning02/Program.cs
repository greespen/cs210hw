using System;

class Program
{
    static void Main(string[] args)
    {
        Resume MyResume = new Resume();
        MyResume._name = "Happy Guy";
        Job job1 = new Job();
        job1. _jobTitle = "zoo keeper";
        job1._company = "zoo";
        job1._startYear = 2019;
        job1._endYear = 2023;
        Job job2 = new Job();
        job2._jobTitle = "teacher";
        job2._company = "school";
        job2._startYear = 2023;
        job2._endYear = 2025;
        MyResume._jobs.Add(job1);
        MyResume._jobs.Add(job2);
        MyResume.Display();

    }
}