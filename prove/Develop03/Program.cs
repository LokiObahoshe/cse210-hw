using System;

//Exceeding Requirements: Added a "suggestion" class to give the user a new scripture quote to study after completing or quitting the application.

class Program
{
    static void Main(string[] args)
    {

        string _words = "For this very reason, make every effort to add to your faith goodness; and to goodness, knowledge; and to knowledge, self-control; and to self-control, perseverance; and to perseverance, godliness; and to godliness, mutual affection; and to mutual affection, love.";
        Reference reference = new Reference("2 Peter", 1, 5, 7);
        Scripture scripture = new Scripture(reference, _words);
        Suggestion suggestion = new Suggestion();

        while (true)
        {
            Console.Clear();
            scripture.GetDisplayText();
            Console.Write("\n\nPress enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                suggestion.DisplaySuggestion();
                break;
            }
            else
            {
                if (scripture.IsCompletelyHidden() == true)
                {
                    suggestion.DisplaySuggestion();
                    break;
                }
                else
                {
                    scripture.HideRandomWords();
                }
            }
        }
    }
}