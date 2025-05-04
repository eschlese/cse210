using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        int guess;

        do
        {
            Console.Write("What is the magic number? ");
            string guessString = Console.ReadLine();
            guess = int.Parse(guessString);

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
        } while (guess != magicNumber);

        Console.WriteLine("You guessed it!");
    }
}