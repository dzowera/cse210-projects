using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine();

        Random random = new Random();
        int i = random.Next(0, 10);
        Console.WriteLine(i);
        

    }
}