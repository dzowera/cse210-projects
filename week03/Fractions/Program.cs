using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.\n");

        // Display the information
        // Set up the new object
        Fractions mynumbers = new Fractions(7, 3);

        // The first fraction
        Console.WriteLine($"Fraction: {mynumbers.GetNumerator()} / {mynumbers.GetDenominator()}");

        // If we change the numerator
        mynumbers.SetNumerator(9);
        Console.WriteLine($"Fraction: {mynumbers.GetNumerator()} / {mynumbers.GetDenominator()}");

        // Change the denominator
        mynumbers.SetDenominator(10);
        Console.WriteLine($"Fraction: {mynumbers.GetNumerator()} / {mynumbers.GetDenominator()}");

        // Check if we can catch the error of 0
        mynumbers.SetDenominator(0);
        Console.WriteLine($"Fraction: {mynumbers.GetNumerator()} / {mynumbers.GetDenominator()}");

        // Display the decimal value
        Console.WriteLine($"Decimal: {mynumbers.GetDecimal():F2}");  // Formatting to 2 decimal places
    }
}