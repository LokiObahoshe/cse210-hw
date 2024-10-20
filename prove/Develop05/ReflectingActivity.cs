using System;
using System.Collections.Generic;
using System.Linq;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you? ",
        "Have you ever done anything like this before? ",
        "How did you get started? ",
        "How did you feel when it was complete? ",
        "What made this time different than other times when you were not as successful? ",
        "What is your favorite thing about this experience? ",
        "What could you learn from this experience that applies to other situations? ",
        "What did you learn about yourself through this experience? ",
        "How can you keep this experience in mind in the future? "
    };

    private List<string> _usedQuestions = new List<string>();
    
    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    private string DisplayPrompt()
    {
        return GetRandomPrompt();
    }

    private string DisplayQuestions()
    {
        return GetRandomQuestion();
    }
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {DisplayPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadKey();
        Console.WriteLine("\nNow ponder on each of the following questions as they're related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write($"> {DisplayQuestions()}");
            ShowSpinner(10);
            Console.WriteLine();

            i++;

            if (i >= _duration)
            {
                break;
            }
        }
        DisplayEndingMessage();
        Console.Clear();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    private string GetRandomQuestion()
    {
        if (_usedQuestions.Count == _questions.Count)
        {
            _usedQuestions.Clear();
            //https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.orderby?view=net-8.0
            //https://stackoverflow.com/questions/14118844/how-does-enumerable-orderby-use-keyselector
            //Shuffling the list
            _questions = _questions.OrderBy(x => Guid.NewGuid()).ToList();
        }

        foreach (var question in _questions)
        {
            if (!_usedQuestions.Contains(question))
            {
                _usedQuestions.Add(question);
                return question;
            }
        }
        return null;
    }
}