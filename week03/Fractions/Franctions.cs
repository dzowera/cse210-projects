using System;


public class Fractions
{
    private int _numerator;
    private int _denominator;

    // Constructor 1: No parameters (defaults to 1/1)
    public Fractions()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor 2: One parameter (numerator only, denominator defaults to 1)
    public Fractions(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor 3: Two parameters (numerator and denominator)
    public Fractions(int numerator, int denominator)
    {
        _numerator = numerator;

        // The denominator must never be equal to zero
        if (denominator == 0)
        {
            Console.WriteLine("Cannot divide by zero. Setting denominator to 1.");
            _denominator = 1;  // Default to 1 if denominator is zero
        }
        else
        {
            _denominator = denominator;
        }
    }

    // Getter for numerator
    public int GetNumerator()
    {
        return _numerator;
    }

    // Getter for denominator
    public int GetDenominator()
    {
        return _denominator;
    }

    // Setter for numerator
    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    // Setter for denominator with error handling for zero
    public void SetDenominator(int denominator)
    {
        if (denominator == 0)
        {
            Console.WriteLine("Cannot divide by zero. Denominator remains unchanged.");
        }
        else
        {
            _denominator = denominator;
        }
    }

    // Method to return the fraction as a string
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to return the decimal value
    public double GetDecimal()
    {
        return (double)_numerator / _denominator;
    }
}
