using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Book book = new Book();

        book._tittle = "Jungle Book";
        book._author = "Leonardo da Vinci";
        book._year = "2020";

        // call what to be displayed

        book.ShowDetails();

    }
}

public class Book 
{
    // the variables
    public string _tittle = "";
    public string _author = "";

    public string _year = "";

    // how do you make the int variable?

// the line below is used for what? separate the variables and responsibilities?
    public Book () 
    {
    }

    public void ShowDetails()
    {
        Console.WriteLine ($"{tittle} by {author}, published in the year {year}");
    }
}