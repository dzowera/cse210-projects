using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine();

        List<int> numbers = new List<int>();
        int user_number;

        Console.WriteLine("Enter any number, hit 0 when done");

        do
        {
            Console.Write("Enter a number: ");
            user_number = int.Parse(Console.ReadLine());
            {
                if (user_number != 0)
                {
                    numbers.Add(user_number);
                }
            }
        } while (user_number != 0);

        int sum = numbers.Sum();
        double average = numbers.Average();
        int large_num = numbers.Max();

        Console.WriteLine();
        Console.WriteLine("below are your stats: ");

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {large_num}");

        
    }
}