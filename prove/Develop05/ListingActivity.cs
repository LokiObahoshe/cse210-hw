using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> _responses = GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");
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

    List<string> GetListFromUser()
    {
        List<string> _userResponses = new List<string>();
        _count = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string input = Console.ReadLine();
            
            if (!string.IsNullOrWhiteSpace(input))
            {
                _userResponses.Add(input);
                _count++;
            }
        }

        return _userResponses;
    }
}