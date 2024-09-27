using System;

public class PromptGenerator
{

    public List<string> _prompts = new List<string>() {
            "What was my best accomplishment today?",
            "How can I further improve my state of mind today?",
            "What was the most productive thing I did today?",
            "What was I most proud of today?",
            "What can I do to add more thrilling experiences to my day?"
        };

        Random random = new Random();

    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count());
        return _prompts[index];
    }
}