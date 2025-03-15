using System;
using System.Collections.Generic; // Needed for List<T>

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // Create the first job
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Create the second job
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Create the resume
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        myResume._jobs.Add(job1); // Add the first job
        myResume._jobs.Add(job2); // Add the second job

        // Display the resume
        myResume.Display();
    }
}

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Method to display job details
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

public class Resume
{
    public string _name; // Name of the person
    public List<Job> _jobs = new List<Job>(); // A list to hold jobs

    // Method to display the resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display(); // Call the Display method of each Job
        }
    }
}
