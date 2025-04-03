using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Reference verseRef = new Reference("John", 17, 3);
        Scripture scripture = new Scripture(verseRef, " And this is life eternal, that they might know thee the only true God, and Jesus Christ, whom thou hast sent.");

        while (!scripture.IsCompletelyHidden())
        {
            // to clear the working space 
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit") break;

            scripture.HideRandomWords(2);
        }

        Console.WriteLine("\nAll words are hidden! Goodbye.");
    }
}