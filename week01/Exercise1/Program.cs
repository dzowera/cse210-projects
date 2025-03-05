using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        // Exercise 1
        // I put only Write so the input is on the same line
         
        Console.Write("What is your name?: ");
        string f_name = Console.ReadLine();  

        Console.Write("What is your last name?: ");
        string l_name = Console.ReadLine();

        Console.WriteLine($"Your name is {l_name}, {f_name} {l_name}");
    }
}