using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        List<string> words = new List<string>();

        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");

        Console.WriteLine(words.Count);

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
        */

        List<int> numbers = new List<int>();

        int userInput = -1;
        int sum = 0;

        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());


            /* Needed to complete the "average" */
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }

        foreach (int number in numbers)
        {
            sum += number;
        }

        /*
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        */
        int max = numbers.Max();

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}