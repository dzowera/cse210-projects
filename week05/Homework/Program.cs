using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        // Create a WritingAssignment object
        WritingAssignment writingAssignment = new WritingAssignment(
            "Mary Waters",
            "European History",
            "The Causes of World War II"
        );

        // Display the summary
        Console.WriteLine(writingAssignment.GetSummary());

        // Display the writing information
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }

}