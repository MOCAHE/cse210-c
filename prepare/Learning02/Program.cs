using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Console.WriteLine();

        //STEP 4: Test your Job class
        Job job1 = new();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2000;
        job1._endYear = 2020;

        Job job2 = new();
        job2._companyName = "Apple";
        job2._jobTitle = "Human Resources";
        job2._startYear = 1999;
        job2._endYear = 2010;

        // Console.WriteLine($"{job1._companyName}");
        // Console.WriteLine($"{job2._companyName}");
        // Console.WriteLine();

        // // STEP 5: Add a Display method to the Job class
        // job1.DisplayJobDetails();
        // Console.WriteLine();

        Resume myResume = new();
        myResume._personName = "Moisés Cano";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
        Console.WriteLine();
    }
}