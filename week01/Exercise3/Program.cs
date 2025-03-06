using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine();

        Console.Write("what is your magic number");
        int magic_number = int.Parse(Console.ReadLine());

        Console.Write("what is your guess");
        int guess = int.Parse(Console.ReadLine());

        if (magic_number > guess)
        {
            Console.WriteLine("Higher");
        }

        else if (magic_number < guess)
        {
            Console.WriteLine("Lower");
        }

        else
        {
            Console.WriteLine("Your guess is write.")
        }

       
        

    }
}