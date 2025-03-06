using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine();

        string response;
        do
        {
            Console.Write("What is your magic number? ");
            int magic_number = int.Parse(Console.ReadLine());

            Console.Write("What is your guess? ");
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
                Console.WriteLine("Your guess is right.");
                Console.Write("Do you want to continue? ");
                response = Console.ReadLine();
            }

        } while (response == "yes");

    }
}