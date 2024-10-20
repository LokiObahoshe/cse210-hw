using System;
using System.Threading;
using System.Collections.Generic;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
    
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nBreathe in...");
            ShowCountDown(3);
            Console.Write("\nNow breathe out...");
            ShowCountDown(3);
        }
        DisplayEndingMessage();
    }
}