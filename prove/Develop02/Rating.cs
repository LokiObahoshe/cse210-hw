using System;
using System.IO;

public class Rating
{

    public void DisplayRate()
    {
        Console.WriteLine("How would you rate your day?: (1-10)");
        string rate = Console.ReadLine();

        Console.WriteLine("\nWould you like to add this rating to one of your saved journals?");
        string userAnswer = Console.ReadLine();

        if (userAnswer.ToLower() == "yes")
        {
            while (true)
            {
                Console.WriteLine("\nWhat is the filename of the saved journal?:");
                string filename = Console.ReadLine();

                if (File.Exists(filename))
                {
                    System.IO.File.AppendAllText(filename, $"Rating of the day: {rate}\n");
                    //https://learn.microsoft.com/en-us/dotnet/api/system.io.file.appendalltext?view=net-8.0
                    //https://stackoverflow.com/questions/51729337/why-is-system-io-file-appendalltext-locking-my-file

                    Console.WriteLine("\nRating recorded. Have a good day!\n");
                    break;
                }
                else
                {
                    Console.WriteLine("\nFile does not exist. Please try again.");
                }
            }
        }
        else
        {
            Console.WriteLine("\nHave a good day!\n");
        }
    }

}