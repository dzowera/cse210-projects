using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // Below is an empty line for output readability 
        Console.WriteLine(); 

        // Setting up variables
        Console.Write("Please enter your grade: ");
        int score = int.Parse(Console.ReadLine());
        string grade;

        if (score >= 90) 
    
        {
            grade = "A";

            if (score % 10 <= 3)
            {
                grade += "-";
            }
        }

        else if (score >= 80 && score < 90) 
        
        {
            grade = "B";

            if (score % 10 >= 7)
            {
                grade += "+";
            } 

            if (score % 10 <= 3)
            {
                grade += "-";
            }
        }

        else if (score >= 70 && score < 80)
        {
            grade = "C";

            if (score % 10 >= 7)
            {
                grade += "+";
            } 

            if (score % 10 <= 3)
            {
                grade += "-";
            }
        }

        else if (score >= 60 && score < 70)
        {
            grade = "D";

            if (score % 10 >= 7)
            {
                grade += "+";
            } 

            if (score % 10 <= 3)
            {
                grade += "-";
            }
        }

        else
        {
            grade = "F";
        }

        if (score >= 70)
        {
            Console.WriteLine("Congratulations! You have passed");
        }

        else
        {
            Console.WriteLine("Sorry, you have not passed. Good luck for your retake.");
        }

        Console.WriteLine($"Your grade is {grade}");

    }
}