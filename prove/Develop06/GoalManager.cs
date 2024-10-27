using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{

    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");

        Console.WriteLine($"\nYour score: {_score} points\n");
    }

    public void ListGoalDetails()
    {

        if (_goals.Count == 0)
        {
            Console.WriteLine("Sorry, you have no goals to display. Please make at least one goal and try again.");
        }

        int counter = 1;
        Console.WriteLine("The goals are:");

        foreach (var goal in _goals)
        {
            Console.WriteLine($"{counter}. {goal.GetDetailString()}");
            counter++;
        }
    }

    public void CreateGoal()
    {

        bool loop = true;

        while (loop)
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Negative Goal");
            Console.WriteLine("5. Go Back");
            Console.Write("Which type of goal would you like to create?: ");
            string userInputGoal = Console.ReadLine();

            if (userInputGoal == "1" || userInputGoal == "2" || userInputGoal == "3" || userInputGoal == "4")
            {
                Console.Write("What is the name of your goal?: ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it?: ");
                string desc = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal?: ");
                string points = Console.ReadLine();

                if (userInputGoal == "1")
                {
                    _goals.Add(new SimpleGoal(name, desc, points));
                    loop = false;
                }
                else if (userInputGoal == "2")
                {
                    _goals.Add(new EternalGoal(name, desc, points));
                    loop = false;
                }
                else if (userInputGoal == "3")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
                    int time = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it many times?: ");
                    int bonus = int.Parse(Console.ReadLine());
                    _goals.Add(new ChecklistGoal(name, desc, points, time, bonus));
                    loop = false;
                }
                else if (userInputGoal == "4")
                {
                    _goals.Add(new NegativeGoal(name, desc, points));
                    loop = false;
                }
                loop = false;
            }
            else if (userInputGoal == "5")
            {
                return;
            }
            else
            {
                Console.WriteLine("\nPlease choose a valid input.\n");
            }
        }
    }

    public void RecordEvent()
    {
        //https://www.geeksforgeeks.org/c-sharp-how-to-get-all-elements-of-a-list-that-match-the-conditions-specified-by-the-predicate/
        //https://stackoverflow.com/questions/674632/generic-list-findall-vs-foreach
        // created a new list to handle the index issues I have encountered.
        List<Goal> availableGoals = _goals.FindAll(g => !g.IsComplete());

        // displays the goals when the user wants to record.
        // It checks the list's indexes to correctly reward
        // the user with the right points. An issue I was
        // experiencing before was the goals stealing
        // points from each other. (In other words,
        // goals kept rewarding the wrong points).
        Console.WriteLine("The goals are:");
        for (int i = 0; i < availableGoals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. ({availableGoals[i].GetName()}) -- {availableGoals[i].Points} points");
        }

        // this if statement checks if the list is empty and returns
        //an error message when the user tries to record.
        if (availableGoals.Count == 0)
        {
            Console.WriteLine("\nSorry, you momentarily have no new goals or have already completed them. Please make at least one goal and try again.");
            return;
        }
        
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        // _goals[index - 1].RecordEvent();

        // this if statement helps prevent the user from trying to access
        // goals from before using their last indexes. If the user tries
        // to use a past index that has a now completed goal, this
        // error will occur.
        if (index < 0 || index >= availableGoals.Count)
        {
            Console.WriteLine("\nThis goal does not exist, please try again.");
            return;
        }

        //var selectedGoal = _goals[index - 1];
        var selectedGoal = availableGoals[index];
        selectedGoal.RecordEvent();

        if (selectedGoal is SimpleGoal simpleGoal)
        {
            int points = int.Parse(selectedGoal.Points);
            _score += points;
            Console.WriteLine($"\nCongratulations! You have earned {points} points!");
        }

        if (selectedGoal is EternalGoal eternalGoal)
        {
            int points = int.Parse(selectedGoal.Points);
            _score += points;
            Console.WriteLine($"\nCongratulations! You have earned {points} points!");
        }

        if (selectedGoal is ChecklistGoal checklistGoal)
        {
            int points = int.Parse(selectedGoal.Points);
            _score += points;
            Console.WriteLine($"\nCongratulations! You have earned {points} points!");
                
            if (selectedGoal.IsComplete())
            {
                int bonus = checklistGoal.Bonus;
                _score += bonus;
                Console.WriteLine($"You've earned an additional {checklistGoal.Bonus} bonus points!");
            }
        }

        if (selectedGoal is NegativeGoal negativeGoal)
        {
            int points = int.Parse(selectedGoal.Points);
            _score -= points;
            Console.WriteLine($"\nYou have lost {points} points.");
        }

        Console.WriteLine();
        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using StreamWriter outputFile = new StreamWriter(filename);
        {
            outputFile.WriteLine(_score);
            Console.WriteLine("\nFile has been saved!");

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!System.IO.File.Exists(filename))
        {
            Console.WriteLine("\nFile not found. Please check the filename and try again.");
            return;
        }

        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(",");

            if (parts[0] == "SimpleGoal")
            {
                bool isComplete = bool.Parse(parts[4]);
                _goals.Add(new SimpleGoal(parts[1], parts[2], parts[3], isComplete));
            }
            else if (parts[0] == "EternalGoal")
            {
                bool isComplete = bool.Parse(parts[4]);
                _goals.Add(new EternalGoal(parts[1], parts[2], parts[3], isComplete));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), bool.Parse(parts[7])));
            }
            else if (parts[0] == "NegativeGoal")
            {
                bool isComplete = bool.Parse(parts[4]);
                _goals.Add(new NegativeGoal(parts[1], parts[2], parts[3], isComplete));
            }
        }
    }
}