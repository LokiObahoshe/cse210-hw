using System;
using System.Collections.Generic;

public class MemorizingActivity : Activity
{
    private int _count;
    private List<string> _vocabWords = new List<string>
    {
        "Inheritance",
        "Version Control",
        "Abstraction",
        "Encapsulation",
        "Classes"
    };

    private List<string> _vocabDesc = new List<string>
    {
        "Inheritance is a fundamental concept that allows a new class to inherit properties and behaviors (methods) from an existing class. This mechanism promotes code reusability and hierarchical classification.",
        "Version Control is a system that records changes to a file or set of files over time so that you can recall specific versions later. It is a fundamental tool for software development, allowing teams to work concurrently on code, track history, and manage changes.",
        "Abstraction involves hiding complex implementation details from the user and providing a simplified interface. In C++, abstraction can be achieved through various means, including classes, access specifiers, and header files.",
        "Encapsulation is a concept that involves combining data and the methods that operate on it into one unit, usually a class. Encapsulation protects data from accidental modification, enhances code organization, and streamlines interaction between program components.",
        "a class is a blueprint for creating objects, providing the initial values for state (member fields or properties) and implementations of behavior (member methods or functions). A class encapsulates data for the object and methods to manipulate that data."
    };

    public MemorizingActivity() : base("Memorizing Activity", "This activity will help you memorize a random list of vocabulary words.")
    {

    }

    public void Run()
    {
        Random random = new Random();

        Console.Clear();
        DisplayStartingMessage();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        _count = 0;

        while (DateTime.Now < endTime)
        {
            int index = random.Next(_vocabWords.Count);
            string words = _vocabWords[index];
            string desc = _vocabDesc[index];

            Console.WriteLine($"----------\nWhat is the definition of this word: {words}");
            Console.WriteLine("\nWhen you feel ready to answer, press enter.");
            Console.ReadKey();
            Console.WriteLine($"\nDescription: {desc}\n");
            _count++;
            ShowCountDown(2);
        }
        Console.WriteLine($"You memorized {_count} vocabulary words!");
        DisplayEndingMessage();
        Console.Clear();
    }
}