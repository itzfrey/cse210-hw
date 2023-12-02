using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create a sample scripture
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        // Display the original scripture
        Console.WriteLine(scripture.GetDisplayText());

        // Ask the user if they want to reveal the hidden words
        Console.Write("\nPress enter to continue or type 'quit' to finish: ");
        string revealResponse = Console.ReadLine().ToLower();

        while (!string.Equals(revealResponse, "quit") && !scripture.IsCompletelyHidden())
        {
            int wordsToHide = 5;
            scripture.HideRandomWords(wordsToHide);

            Console.WriteLine(scripture.GetDisplayText());

            // If all words are hidden, end the loop
            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.Write("\nPress enter to continue or type 'quit' to finish: ");
            revealResponse = Console.ReadLine().ToLower();
        }
    }
}
