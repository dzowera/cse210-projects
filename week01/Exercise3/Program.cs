using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine();

        string response = "eya";

        while (response == "eya")
        {
            Console.Write("Ukufuna usewereso?: ");
            response = Console.ReadLine();
        }

    }
}