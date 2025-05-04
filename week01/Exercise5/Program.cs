using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        int sqNumber = SquareNumber(number);
        DisplayResult(userName, sqNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Input your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Input your favourite number: ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);
        return number;
    }

    static int SquareNumber(int number)
    {
        int new_number = number * number;
        return new_number;
    }

    static void DisplayResult(string userName, int number)
    {
        Console.WriteLine($"{userName}, the square of your number is {number}");
    }
}