using System;

class Program
{
    static void Main(string[] args)
    {

        /*
        Console.Write("What is the magic number?: ");
        string magic = Console.ReadLine();
        int number = int.Parse(magic);
        */

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 100);

        int guess = -99;
        int guessTrack = 1;

        while (guess != number)
        {
            Console.Write("What is your guess?: ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Lower");
                guessTrack += 1;
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
                guessTrack += 1;
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You guessed {guessTrack} time(s)!");
            }
        }
    }
}