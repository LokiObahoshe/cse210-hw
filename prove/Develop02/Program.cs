using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to your Journal!");

        PromptGenerator promptGenerator = new PromptGenerator();
        Entry entry = new Entry();
        Journal journal = new Journal();

        while (true)
        {

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do?: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine();
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                string date = DateTime.Now.ToString();
                entry = new Entry();

                entry._promptText = prompt;
                entry._entryText = response;
                entry._date = date;

                journal.AddEntry(entry);
                Console.WriteLine();
            }
            else if (userInput == "2")
            {
                Console.WriteLine();
                journal.DisplayAll();
                Console.WriteLine();
            }
            else if (userInput == "3")
            {
                Console.WriteLine();
                Console.Write("What is the filename?: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine();
            }
            else if (userInput == "4")
            {
                Console.WriteLine();
                Console.Write("What is the filename?: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (userInput == "5")
            {
                Console.WriteLine();
                Console.WriteLine("Have a good day!");
                Console.WriteLine();
                break;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid option, please try again.");
                Console.WriteLine();
            }
        }
        
    }
}
