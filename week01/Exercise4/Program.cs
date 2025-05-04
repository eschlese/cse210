using System;
using System.Diagnostics;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numList = new List<int>();
        int userNumber = -1;

        do
        {
            Console.Write("Enter a number: ");
            string numString = Console.ReadLine();
            userNumber = int.Parse(numString);

            if (userNumber != 0)
            {
                numList.Add(userNumber);
            }
        } while (userNumber != 0);

        int sum = 0;
        int largestNum = numList[0];
        int smallestPositiveNum = numList[0];
        foreach (int number in numList)
        {
            sum = sum + number;
            if (number > largestNum)
            {
                largestNum = number;
            }
            if (number < smallestPositiveNum && number > 0)
            {
                smallestPositiveNum = number;
            }
        }

        double average = ((double) sum) / numList.Count;

        numList.Sort();

        Console.WriteLine($"The sum is {sum}\nThe average is {average}\nThe largest number is {largestNum}");
        Console.WriteLine($"The smallest positive number is {smallestPositiveNum}");

        foreach (int number in numList)
        {
            Console.WriteLine($"{number}");
        }

    }
}