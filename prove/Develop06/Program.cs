using System;

// Exceeding Requirement: Added a more detailed and functioning way
// to record events along with a whole new "NegativeGoal"
// class for the user to use. This new goal deducts points
// for bad habits.

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalmanager = new GoalManager();
        Console.Clear();

        while (true)
        {
            goalmanager.Start();

            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                goalmanager.CreateGoal();
            }
            else if (userInput == "2")
            {
                Console.WriteLine();
                goalmanager.ListGoalDetails();
            }
            else if (userInput == "3")
            {
                Console.WriteLine();
                goalmanager.SaveGoals();
            }
            else if (userInput == "4")
            {
                Console.WriteLine();
                goalmanager.LoadGoals();
            }
            else if (userInput == "5")
            {
                Console.WriteLine();
                goalmanager.RecordEvent();
            }
            else if (userInput == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("\nPlease choose a valid input.");
            }
        }
    }
}