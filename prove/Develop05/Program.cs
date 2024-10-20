using System;

//Exceeding Requirements: Added a whole new class called "MemorizingActivity" that makes the user memorize a list of randomized vocabulary words.

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingactivity = new BreathingActivity();
        ReflectingActivity reflectingactivity = new ReflectingActivity();
        ListingActivity listingactivity = new ListingActivity();
        MemorizingActivity memorizingactivity = new MemorizingActivity();
        Console.Clear();
        while (true)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Start memorizing activity");
            Console.WriteLine("5. Quit");

            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
                {
                    breathingactivity.Run();
                }
                else if (userInput == "2")
                {
                    reflectingactivity.Run();
                }
                else if (userInput == "3")
                {
                    listingactivity.Run();
                }
                else if (userInput == "4")
                {
                    memorizingactivity.Run();
                }
                else if (userInput == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nPlease choose a valid input.\n");
                }
        }
    }
}