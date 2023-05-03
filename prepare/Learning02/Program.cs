using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._myTitle = "Software Engineer";
        job1._companyTitle = "Microsoft";
        job1._beginningYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._myTitle = "Manager";
        job2._companyTitle = "Apple";
        job2._beginningYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._myName = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

     

    }
}